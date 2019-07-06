(function ($) {
  'use strict';
 
  $(function () {
      // Validacion formulario agregar cargo
      $('#formAgregarCargo').validate({
          rules: {
              descripcionCargo: "required"
          },
          messages: {

              descripcionCargo: {
                  required: "Campo Obligatorio"
              }

          },
          errorPlacement: function (label, element) {
              label.addClass('mt-2 text-danger col-12 pl-0');
              label.insertAfter(element);
          },
          highlight: function (element, errorClass) {
              $(element).parent().addClass('has-danger');
              $(element).addClass('form-control-danger');
          }
      });

      // Validacion formulario modificar cargo

      $('#formModificarCargo').validate({
          rules: {
              descripcionCargoModificar: "required"
          },
          messages: {

              descripcionCargoModificar: {
                  required: "Campo Obligatorio"
              }

          },
          errorPlacement: function (label, element) {
              label.addClass('mt-2 text-danger col-12 pl-0');
              label.insertAfter(element);
          },
          highlight: function (element, errorClass) {
              $(element).parent().addClass('has-danger');
              $(element).addClass('form-control-danger');
          }
      });

      // Validacion formulario agregar Turno
      $('#formAgregarTurno').validate({
          rules: {
              descripcionTurno: "required"
          },
          messages: {

              descripcionTurno: {
                  required: "Campo Obligatorio"
              }

          },
          errorPlacement: function (label, element) {
              label.addClass('mt-2 text-danger col-12 pl-0');
              label.insertAfter(element);
          },
          highlight: function (element, errorClass) {
              $(element).parent().addClass('has-danger');
              $(element).addClass('form-control-danger');
          }
      });

      // Validacion formulario modificar turno

      $('#formModificarTurno').validate({
          rules: {
              descripcionTurnoModificar: "required"
          },
          messages: {

              descripcionTurnoModificar: {
                  required: "Campo Obligatorio"
              }

          },
          errorPlacement: function (label, element) {
              label.addClass('mt-2 text-danger col-12 pl-0');
              label.insertAfter(element);
          },
          highlight: function (element, errorClass) {
              $(element).parent().addClass('has-danger');
              $(element).addClass('form-control-danger');
          }
      });


      // Validacion formulario agregar rol
      $('#formAgregarRol').validate({
          rules: {
              descripcionRol: "required"
          },
          messages: {

              descripcionRol: {
                  required: "Campo Obligatorio"
              }

          },
          errorPlacement: function (label, element) {
              label.addClass('mt-2 text-danger col-12 pl-0');
              label.insertAfter(element);
          },
          highlight: function (element, errorClass) {
              $(element).parent().addClass('has-danger');
              $(element).addClass('form-control-danger');
          }
      });

      // Validacion formulario modificar rol

      $('#formModificarRol').validate({
          rules: {
              descripcionRolModificar: "required"
          },
          messages: {

              descripcionRolModificar: {
                  required: "Campo Obligatorio"
              }

          },
          errorPlacement: function (label, element) {
              label.addClass('mt-2 text-danger col-12 pl-0');
              label.insertAfter(element);
          },
          highlight: function (element, errorClass) {
              $(element).parent().addClass('has-danger');
              $(element).addClass('form-control-danger');
          }
      });


      $('#formAgregarUsuario').validate({
          rules: {
              run: {
                  required: true,
                  maxlength: 10
              },
              nombre: {
                  required: true
              },
              apellido: {
                  required: true
              },
              usuario: {
                  required: true
              },
              contrasena: {
                  required: true
              },
              IdEmpresa: "required",
              IdRol: "required",
              IdTurno: "required",
              Idcargo: "required"
          },
          messages: {

              run: {
                  required: "Campo Obligatorio",
                  maxlength: "Este campo no puede contener mas de 10 caracteres"
              },
              nombre: {
                  required: "Campo Obligatorio"
              },
              apellido: {
                  required: "Campo Obligatorio"
              },
              usuario: {
                  required: "Campo Obligatorio"
              },
              contrasena: {
                  required: "Campo Obligatorio"
              },
              IdEmpresa: {
                  required: "Campo Obligatorio"
              },
              IdRol: {
                  required: "Campo Obligatorio"
              },
              IdTurno: {
                  required: "Campo Obligatorio"
              },
              Idcargo: {
                  required: "Campo Obligatorio"
              }

          },
          errorPlacement: function (label, element) {
              label.addClass('mt-2 text-danger col-12 pl-0');
              label.insertAfter(element);
          },
          highlight: function (element, errorClass) {
              $(element).parent().addClass('has-danger');
              $(element).addClass('form-control-danger');
          }
      });



      $('#formModificarUsuario').validate({
          rules: {
              run: {
                  required: true,
                  maxlength: 10
              },
              nombre: {
                  required: true
              },
              apellido: {
                  required: true
              },
              usuario: {
                  required: true
              },
              contrasena: {
                  required: true
              },
              IdEmpresa: "required",
              IdRol: "required",
              IdTurno: "required",
              Idcargo: "required"
          },
          messages: {

              run: {
                  required: "Campo Obligatorio",
                  maxlength: "Este campo no puede contener mas de 10 caracteres"
              },
              nombre: {
                  required: "Campo Obligatorio"
              },
              apellido: {
                  required: "Campo Obligatorio"
              },
              usuario: {
                  required: "Campo Obligatorio"
              },
              contrasena: {
                  required: "Campo Obligatorio"
              },
              IdEmpresa: {
                  required: "Campo Obligatorio"
              },
              IdRol: {
                  required: "Campo Obligatorio"
              },
              IdTurno: {
                  required: "Campo Obligatorio"
              },
              Idcargo: {
                  required: "Campo Obligatorio"
              }

          },
          errorPlacement: function (label, element) {
              label.addClass('mt-2 text-danger col-12 pl-0');
              label.insertAfter(element);
          },
          highlight: function (element, errorClass) {
              $(element).parent().addClass('has-danger');
              $(element).addClass('form-control-danger');
          }
      });



      // Validacion formulario agregar Empresa
      $('#formAgregarEmpresa').validate({
          rules: {
              descripcionEmpresa: "required"
          },
          messages: {

              descripcionEmpresa: {
                  required: "Campo Obligatorio"
              }

          },
          errorPlacement: function (label, element) {
              label.addClass('mt-2 text-danger col-12 pl-0');
              label.insertAfter(element);
          },
          highlight: function (element, errorClass) {
              $(element).parent().addClass('has-danger');
              $(element).addClass('form-control-danger');
          }
      });

      // Validacion formulario modificar Empresa

      $('#formModificarEmpresa').validate({
          rules: {
              descripcionEmpresaModificar: "required"
          },
          messages: {

              descripcionEmpresaModificar: {
                  required: "Campo Obligatorio"
              }

          },
          errorPlacement: function (label, element) {
              label.addClass('mt-2 text-danger col-12 pl-0');
              label.insertAfter(element);
          },
          highlight: function (element, errorClass) {
              $(element).parent().addClass('has-danger');
              $(element).addClass('form-control-danger');
          }
      });






  });
})(jQuery);