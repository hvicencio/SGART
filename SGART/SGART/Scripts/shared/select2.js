(function($) {
  'use strict';
  if ($(".js-example-basic-single").length) {
    $(".js-example-basic-single").select2({
      placeholder: "Valor número",
          language: "es"
    });
  }
  if ($(".select2asignados").length) {
    $(".select2asignados").select2();
  }
  if ($(".select2pagados").length) {
    $(".select2pagados").select2();
  }
  if ($(".js-example-basic-multiple").length) {
    $(".js-example-basic-multiple").select2();
  }
})(jQuery);