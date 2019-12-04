
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

        empleadoList.showempleados = false;
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
        empleadoList.Mostrarempleados = function(){
            if(!empleadoList.showempleados){
                
                empleadoList.showempleados = true;
            }else{
            empleadoList.showempleados = false;
            }
    }
        empleadoList.ValidarDNI = function (ChequearDNI) {
            var DNIValido = true;
            empleadoList.empleados.forEach(element => {
                if (element.dni == ChequearDNI) {
                    DNIValido = false;
                }
            })
            return DNIValido;
        }

        empleadoList.ValidarNombre = function () {
            var nombreValido = true;
            if (empleadoList.nuevoEmpleadoNombre == null || empleadoList.nuevoEmpleadoNombre == "" || empleadoList.nuevoEmpleadoNombre == undefined) {
                nombreValido = false;
            }
            return nombreValido;
        }

        empleadoList.ValidarEmpleado = function () {
            if (!this.ValidarNombre()) {
                alert("Debe completar el nombre");
            }
            else {
                if (!this.ValidarDNI(empleadoList.nuevoEmpleadoDNI)) {
                    alert("El DNI ya esta ingresado");
                }
                else {
                    this.addEmpleado();
                }
            }
        };





        empleadoList.addEmpleado = function () {
            var empleado = {
                nombre: empleadoList.nuevoEmpleadoNombre,
                apellido: empleadoList.nuevoEmpleadoApellido,
                edad: empleadoList.nuevoEmpleadoEdad,
                dni: empleadoList.nuevoEmpleadoDNI,
                estado: empleadoList.nuevoEstado
            }
            empleadoList.empleados.push(empleado);
            var listString = JSON.stringify(empleadoList.empleados);
            localStorage.setItem('Empleados', listString);
        };


        empleadoList.delEmpleado = function (empleado, index) {
            empleadoList.empleados.splice(index, 1);
            localStorage.setItem('Empleados', JSON.stringify(empleadoList.empleados))
        };



        empleadoList.indexAEditar = 0;

        empleadoList.ModificarEmpleado = function (empleado, index) {
            empleadoList.indexAEditar = index;
            empleadoList.nuevoEmpleadoNombre = empleado.nombre;
            empleadoList.nuevoEmpleadoApellido = empleado.apellido;
            empleadoList.nuevoEmpleadoEdad = empleado.edad;
            empleadoList.nuevoEmpleadoDNI = empleado.dni;
            empleadoList.nuevoEstado = empleado.nuevoEstado;
        };

        empleadoList.SaveModificarEmpleado = function () {

            empleadoList.empleados[empleadoList.indexAEditar].nombre = empleadoList.nuevoEmpleadoNombre;
            empleadoList.empleados[empleadoList.indexAEditar].apellido = empleadoList.nuevoEmpleadoApellido;
            empleadoList.empleados[empleadoList.indexAEditar].edad = empleadoList.nuevoEmpleadoEdad;
            empleadoList.empleados[empleadoList.indexAEditar].dni = empleadoList.nuevoEmpleadoDNI;
            empleadoList.empleados[empleadoList.indexAEditar].estado = empleadoList.nuevoEstado;
        };

        empleadoList.nuevoEmpleado = function () {
            empleadoList.nuevoEmpleadoNombre = "";
            empleadoList.nuevoEmpleadoApellido = "";
            empleadoList.nuevoEmpleadoEdad = "";
            empleadoList.nuevoEmpleadoDNI = "";
            empleadoList.nuevoEstado = "";
            console.log(localStorage.getItem('Estados'));
        };

    });