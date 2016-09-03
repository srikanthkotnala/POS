$(document).ready(function () {
    ///Search for  Store / Location / LocationID -Vinod
    $('#txtTLocationSearch').keyup(function () {
        $('.TlocData').hide();
        $('#NoRecords').hide();
        var searchText = $('#txtTLocationSearch').val().toLocaleLowerCase();
        var txtLength = searchText.length;
        var searchExists = false;
        if (txtLength >= 2) {
            $('.TlocData').each(function () {
                var locText = $(this).html();
                if (locText.toLowerCase().indexOf(searchText) >= 0) {
                    $(this).show();
                    searchExists = true;
                }
            });
            if (!searchExists) {
                $('#NoRecords').show();
            }
        }
        else {
            $('.TlocData').show();
        }
    });



    ///On selecting location/store get details by id -Vinod
    $(".MasterTStore").click(function () {
        var locID = $(this).attr('data-SLocationID');

        $.ajax({
            url: '../Terminal/GetLocationById',
            data: { 'locationID': locID },
            type: "post",
            cache: false,
            success: function (data) {
                $('#TerminalDetails').html(data);
            },
            error: function (xhr, ajaxOptions, thrownError) {
                alert("Error in geting data from server. Please try again.");
            }
        });
    });
    $("#btnNewTerminal").click(function () {
        var locID = $(this).attr('data-LocationID');
        $.ajax({
            url: '../Terminal/GetLocationById',
            data: { 'locationID': null },
            type: "post",
            cache: false,
            success: function (data) {
                $('#LocationDetails').html(data);
            },
            error: function (xhr, ajaxOptions, thrownError) {
                alert("Error in geting data from server. Please try again.");
            }
        });
    });
});