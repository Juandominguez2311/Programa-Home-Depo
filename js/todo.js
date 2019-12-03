angular.module('EmpleadosList', [])
    .controller('EmpleadosListController', function () {
        var empleadoslist = this;
        empleadoslist.todos = [
            { text: 'learn AngularJS', done: true },
            { text: 'build an AngularJS app', done: false }];

       
        if (localStorage.getItem("Usuarios")) {
            empleadoslist.usuarios = JSON.parse(localStorage.getItem('Usuarios'));
        }
        else {
            empleadoslist.usuarios = [];
        }

        if (localStorage.getItem("Estados")) {
            empleadoslist.EstadosIndex = JSON.parse(localStorage.getItem('Estados'));
        }
        else {
            alert('Por favor añadir un estado')
        }


        empleadoslist.addTodo = function () {
            empleadoslist.todos.push({ text: empleadoslist.todoText, done: false });
            empleadoslist.todoText = '';
        };

        empleadoslist.remaining = function () {
            var count = 0;
            angular.forEach(empleadoslist.todos, function (todo) {
                count += todo.done ? 0 : 1;
            });
            return count;
        };



        empleadoslist.addUsuario = function () {
            var usuario = { 
                nombre: empleadoslist.NuevoEmpleadoNombre,
                apellido: empleadoslist.NuevoEmpleadoApellido,
                edad: empleadoslist.NuevoEmpleadoEdad,
                estado: empleadoslist.NewEstado
            }
            empleadoslist.usuarios.push(usuario);
            var listString = JSON.stringify(empleadoslist.usuarios);
            localStorage.setItem('Usuarios', listString);
        };


        empleadoslist.delUsuario = function (usuario, index) {
            empleadoslist.usuarios.splice(index, 1);
            localStorage.setItem('Usuarios', JSON.stringify(empleadoslist.usuarios))
        };

        empleadoslist.indexAEditar = 0;

        empleadoslist.ModificarUsuario = function (usuario, index) {
            empleadoslist.indexAEditar = index;
            empleadoslist.NuevoEmpleadoNombre = usuario.nombre;
            empleadoslist.NuevoEmpleadoApellido = usuario.apellido;
            empleadoslist.NuevoEmpleadoEdad=usuario.edad;
            empleadoslist.NewEstado=usuario.NewEstado;
        };

        empleadoslist.SaveModificarUsuario = function () {

            empleadoslist.usuarios[empleadoslist.indexAEditar].nombre = empleadoslist.NuevoEmpleadoNombre;
            empleadoslist.usuarios[empleadoslist.indexAEditar].apellido = empleadoslist.NuevoEmpleadoApellido;
            empleadoslist.usuarios[empleadoslist.indexAEditar].edad = empleadoslist.NuevoEmpleadoEdad;
            empleadoslist.usuarios[empleadoslist.indexAEditar].estado = empleadoslist.NewEstado;
        };

        empleadoslist.nuevoUsuario = function () {
            empleadoslist.NuevoEmpleadoNombre = "";
            empleadoslist.NuevoEmpleadoApellido = "";
            empleadoslist.NuevoEmpleadoEdad="";
            empleadoslist.NewEstado = "";
            console.log(localStorage.getItem('Estados'));
        };
    });