
angular.module('empleadosApp', [])
.controller('EmpleadosListController', function () {
    var empleadoList = this;
    empleadoList.todos = [
        { text: 'learn AngularJS', done: true },
        { text: 'build an AngularJS app', done: false }];


    if (localStorage.getItem("Empleados")) {
        empleadoList.empleados = JSON.parse(localStorage.getItem('Empleados'));
    }
    else {
        empleadoList.empleados = [];
    }

    if (localStorage.getItem("Estados")) {
        empleadoList.EstadosIndex = JSON.parse(localStorage.getItem('Estados'));
    }
    else {
        alert('Por favor añadir un estado')
    }



    empleadoList.showFormulario = false;
    empleadoList.soyAlta = false;

    empleadoList.addTodo = function () {
        empleadoList.todos.push({ text: empleadoList.todoText, done: false });
        empleadoList.todoText = '';
    };

    empleadoList.remaining = function () {
        var count = 0;
        angular.forEach(empleadoList.todos, function (todo) {
            count += todo.done ? 0 : 1;
        });
        return count;
    };


    empleadoList.addUsuario = function () {
        var empleado = { 
            nombre: empleadoList.NewEmpleadoNombre,
            apellido: empleadoList.NewEmpleadoApellido,
            dni: empleadoList.NewEmpleadoDNI,
            estado: empleadoList.NewEstado
        }
        empleadoList.empleados.push(empleado);
        var listString = JSON.stringify(empleadoList.empleados);
        localStorage.setItem('Empleados', listString);
    };


    empleadoList.delUsuario = function (empleado, index) {
        empleadoList.empleados.splice(index, 1);
        localStorage.setItem('Empleados', JSON.stringify(empleadoList.empleados))
    };

    empleadoList.indexAEditar = 0;

    empleadoList.ModificarUsuario = function (empleado, index) {
        empleadoList.showFormulario = true;
        empleadoList.soyAlta = false;
        empleadoList.indexAEditar = index;
        empleadoList.NewEmpleadoNombre = empleado.nombre;
        empleadoList.NewEmpleadoApellido = empleado.apellido;
        empleadoList.NewEmpleadoDNI = empleado.dni;
        empleadoList.NewEstado = empleado.NewEstado;
    };

    empleadoList.SaveModificarUsuario = function () {

        empleadoList.empleados[empleadoList.indexAEditar].nombre = empleadoList.NewEmpleadoNombre;
        empleadoList.empleados[empleadoList.indexAEditar].apellido = empleadoList.NewEmpleadoApellido;
        empleadoList.empleados[empleadoList.indexAEditar].dni = empleadoList.NewEmpleadoDNI;
        empleadoList.empleados[empleadoList.indexAEditar].estado = empleadoList.NewEstado;
    };

    empleadoList.nuevoUsuario = function () {
        empleadoList.NewEmpleadoNombre = "";
        empleadoList.NewEmpleadoApellido = "";
        empleadoList.NewEmpleadoDNI = "";
        empleadoList.NewEstado = "";
        console.log(localStorage.getItem('Estados'));
    };

});