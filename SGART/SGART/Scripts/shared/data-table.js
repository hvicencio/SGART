(function ($) {
  'use strict';
  $(function () {
      $('#order-listing').DataTable({
          "aLengthMenu": [
              [5, 10, 15, -1],
              [5, 10, 15, "All"]
          ],
          "iDisplayLength": 5,
          "language": {
              search: ""
          },
          "language": {
              "info": "Mostrando  _PAGE_ de _PAGES_ Paginas",
              "paginate": {
                  "first": "Primera",
                  "last": "Ultima",
                  "next": "Sigiente",
                  "previous": "Anterior"
              },
              "lengthMenu": "Ver _MENU_ Elementos",
              "search": "Buscar:",
              "emptyTable": "No hay datos",
              "infoEmpty": "Mostrando 0 de 0 Elementos",
          },
          "ordering": false
      });
      $('#order-listing').each(function () {
          var datatable = $(this);
          // SEARCH - Add the placeholder for Search and Turn this into in-line form control
          var search_input = datatable.closest('.dataTables_wrapper').find('div[id$=_filter] input');
          search_input.attr('placeholder', 'Buscar');
          search_input.removeClass('form-control-sm');
          // LENGTH - Inline-Form control
          var length_sel = datatable.closest('.dataTables_wrapper').find('div[id$=_length] select');
          length_sel.removeClass('form-control-sm');
      });
  });
  $(function () {
    $('#order-listing2').DataTable({
        "aLengthMenu": [
            [5, 10, 15, -1],
            [5, 10, 15, "All"]
        ],
        "iDisplayLength": 5,
        "language": {
            search: ""
        },
        "language": {
            "info": "Mostrando  _PAGE_ de _PAGES_ Paginas",
            "paginate": {
                "first": "Primera",
                "last": "Ultima",
                "next": "Sigiente",
                "previous": "Anterior"
            },
            "lengthMenu": "Ver _MENU_ Elementos",
            "search": "Buscar:",
            "emptyTable": "No hay datos",
            "infoEmpty": "Mostrando 0 de 0 Elementos",
        },
        "ordering": false
    });
    $('#order-listing2').each(function () {
        var datatable = $(this);
        // SEARCH - Add the placeholder for Search and Turn this into in-line form control
        var search_input = datatable.closest('.dataTables_wrapper').find('div[id$=_filter] input');
        search_input.attr('placeholder', 'Buscar');
        search_input.removeClass('form-control-sm');
        // LENGTH - Inline-Form control
        var length_sel = datatable.closest('.dataTables_wrapper').find('div[id$=_length] select');
        length_sel.removeClass('form-control-sm');
    });
});
$(function () {
    $('#order-listing3').DataTable({
        "aLengthMenu": [
            [5, 10, 15, -1],
            [5, 10, 15, "All"]
        ],
        "iDisplayLength": 5,
        "language": {
            search: ""
        },
        "language": {
            "info": "Mostrando  _PAGE_ de _PAGES_ Paginas",
            "paginate": {
                "first": "Primera",
                "last": "Ultima",
                "next": "Sigiente",
                "previous": "Anterior"
            },
            "lengthMenu": "Ver _MENU_ Elementos",
            "search": "Buscar:",
            "emptyTable": "No hay datos",
            "infoEmpty": "Mostrando 0 de 0 Elementos",
        },
        "ordering": false
    });
    $('#order-listing3').each(function () {
        var datatable = $(this);
        // SEARCH - Add the placeholder for Search and Turn this into in-line form control
        var search_input = datatable.closest('.dataTables_wrapper').find('div[id$=_filter] input');
        search_input.attr('placeholder', 'Buscar');
        search_input.removeClass('form-control-sm');
        // LENGTH - Inline-Form control
        var length_sel = datatable.closest('.dataTables_wrapper').find('div[id$=_length] select');
        length_sel.removeClass('form-control-sm');
    });
});
})(jQuery);