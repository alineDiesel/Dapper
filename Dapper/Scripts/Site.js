$(document).ready(function () {

    if (!$(".div-cadastrados>table>tbody>tr").length) {

    }

    $(".btn-add").click(function () {
        $(this).attr("hidden", "hidden");
        $(".div-cadastro").fadeIn();
    });

    $(".btn-cancelar").click(function () {
        $(".div-cadastro").hide();
        $(".btn-add").removeAttr("hidden");
        $("form")[0].reset();
        $("#txtID").val("0");
    });
});