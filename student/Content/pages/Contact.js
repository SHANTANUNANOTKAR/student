var SaveContact = function () {
    var name = $("#txtName").val();
    var address = $("#txtAddress").val();
    var contact = $("#txtContact").val();
    var model = { Name: name, Address: address, Contact: contact, };
    $.ajax({
        url: "/Contact/SaveContact",
        method: "Post",
        data: JSON.stringify(model),
        contentType: "application/json,charset=utf-8",
        dataType: "json",
        success: function (response) {

        }
    })
};