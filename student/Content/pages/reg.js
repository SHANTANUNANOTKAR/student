var savereg = function () {
    var name = $("#txtName").val();
    var address = $("#txtAddress").val();
    var mobile = $("#txtMobile").val();
    var email = $("#txtEmail").val();
    var model = { Name: name, Address: address, Email: email, Mobile: mobile, };
    $.ajax({
        url: "/reg/Savereg",
        method: "post",
        data: JSON.stringify(model),
        contentType: "application/json;charset=utf-8",
        dataType: "json",
        success: function (response) {
            alert("Successfull");
        }
    })

};