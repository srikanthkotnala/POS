$(document).ready(function () {
  
    $('#txtVLocationSearch').keyup(function () {
        $('.VlocData').hide();
        $('#NoRecords').hide();
        var searchText = $('#txtVLocationSearch').val().toLocaleLowerCase();
        var txtLength = searchText.length;
        var searchExists = false;
        if (txtLength >= 2) {

            $('.VlocData').each(function () {
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
            $('.VlocData').show();
        }
    });

   
    $(".MasterVStore").click(function () {
        var locID = $(this).attr('data-VendorID');
        $.ajax({
            url: '../Vendor/GetByVendorId',
            data: { 'VendorID': locID },
            type: "post",
            cache: false,
            success: function (data) {
                $('#VendorDetails').html(data);
            },
            error: function (xhr, ajaxOptions, thrownError) {
                alert("Error in geting data from server. Please try again.");
            }
        });
    });

    $("#btnNewVendor").click(function () {
        var locID = $(this).attr('data-VendorID');
        $.ajax({
            url: '../Vendor/GetByVendorId',
            data: { 'VendorID': null },
            type: "post",
            cache: false,
            success: function (data) {
                $('#VendorDetails').html(data);
            },
            error: function (xhr, ajaxOptions, thrownError) {
                alert("Error in geting data from server. Please try again.");
            }
        });
    });

});