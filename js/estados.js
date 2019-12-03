angular.module('todoApp', [])
    .controller('empleadoslistEstados', function () {
        var todoEstados = this;
        todoEstados.todos = [
            { text: 'learn AngularJS', done: true },
            { text: 'build an AngularJS app', done: false }];

        
        if (localStorage.getItem("Estados")) {
            todoEstados.estados = JSON.parse(localStorage.getItem('Estados'));
        }
        else {
            todoEstados.estados = [];
        }

        todoEstados.showFormulario = false;
        todoEstados.soyAlta = false;

        todoEstados.addTodo = function () {
            todoEstados.todos.push({ text: todoEstados.todoText, done: false });
            todoEstados.todoText = '';
        };

        todoEstados.remaining = function () {
            var count = 0;
            angular.forEach(todoEstados.todos, function (todo) {
                count += todo.done ? 0 : 1;
            });
            return count;
        };



        todoEstados.addEstado = function () {
            var estado = { estado: todoEstados.NuevoEmpleadoNombre, IdEstado: todoEstados.NuevoEmpleadoIdEstado}
            todoEstados.estados.push(estado);
            var listString = JSON.stringify(todoEstados.estados);
            localStorage.setItem('Estados', listString);
        };


        todoEstados.delEstado = function (index) {
            todoEstados.estados.splice(index, 1);
            localStorage.setItem('Estados', JSON.stringify(todoEstados.estados))
        };

        todoEstados.indexAEditar = 0;

        todoEstados.ModificarEstado = function (estado, index) {
            todoEstados.showFormulario = true;
            todoEstados.soyAlta = false;
            todoEstados.indexAEditar = index;
            todoEstados.NuevoEmpleadoNombre = estado.nombre;
            todoEstados.NuevoEmpleadoIdEstado = estado.IdEstado;

            
        };

        todoEstados.SaveModificarEstado = function () {

            todoEstados.estados[todoEstados.indexAEditar].nombre = todoEstados.NuevoEmpleadoNombre;
            todoEstados.estados[todoEstados.indexAEditar].IdEstado = todoEstados.NuevoEmpleadoIdEstado;
            
        };

        todoEstados.nuevoEstado = function () {
            todoEstados.NuevoEmpleadoNombre = "";
            todoEstados.NuevoEmpleadoIdEstado = "";
            todoEstados.showFormulario = true;
            todoEstados.soyAlta = true;
        };

    });