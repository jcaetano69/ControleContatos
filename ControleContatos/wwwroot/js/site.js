// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


$(document).ready(function () {


   
    $('#table-contatos').DataTable({
        "paging": true,          // Habilita a paginação
        "pageLength": 3,        // Define o número de itens por página
        "lengthChange": true,    // Permite ao usuário alterar o número de       itens por página
        "searching": true,       // Habilita a funcionalidade de busca
        "ordering": true,       // Habilita a ordenação das colunas
        "info": true,           // Exibe informações sobre a paginação
        "autoWidth": false       // Desabilita o ajuste automático da largura das colunas
    });
    });


    $('#table-contatos').DataTable({
        "ordering": true,
        "paging": true,
        "searching": true,
        "oLanguage": {
            "sEmptyTable": "Nenhum registro encontrado na tabela",
            "sInfo": "Mostrar _START_ até _END_ de _TOTAL_ registros",
            "sInfoEmpty": "Mostrar 0 até 0 de 0 Registros",
            "sInfoFiltered": "(Filtrar de _MAX_ total registros)",
            "sInfoPostFix": "",
            "sInfoThousands": ".",
            "sLengthMenu": "Mostrar _MENU_ registros por pagina",
            "sLoadingRecords": "Carregando...",
            "sProcessing": "Processando...",
            "sZeroRecords": "Nenhum registro encontrado",
            "sSearch": "Pesquisar",
            "oPaginate": {
                "sNext": "Proximo",
                "sPrevious": "Anterior",
                "sFirst": "Primeiro",
                "sLast": "Ultimo"
            },
            "oAria": {
                "sSortAscending": ": Ordenar colunas de forma ascendente",
                "sSortDescending": ": Ordenar colunas de forma descendente"
            }
        }
    });

$(' .close-alert').click(function () {
    $('.alert').hide('hide');
})