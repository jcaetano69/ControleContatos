// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$(document).ready(function () {
    $('table-contatos').DataTable();
});

let table = new DataTable('#table-contatos');

@section scripts {
    <script>
        $(document).ready(function () {
            $('#table-contatos').DataTable({
                "paging": true,          // Habilita a paginação
                "pageLength": 10,        // Define o número de itens por página
                "lengthChange": true,    // Permite ao usuário alterar o número de itens por página
                "searching": true,       // Habilita a funcionalidade de busca
                "ordering": true,       // Habilita a ordenação das colunas
                "info": true,           // Exibe informações sobre a paginação
                "autoWidth": false       // Desabilita o ajuste automático da largura das colunas
            });
        });
    </script>
}

$(' .close-alert').click(function () {
    $('.alert').hide('hide');
})