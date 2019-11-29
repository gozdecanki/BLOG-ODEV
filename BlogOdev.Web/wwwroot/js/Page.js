var Page = {
    Contact: {
        Send: function () {
            var name = $("#Name").val();
            var surname = $("#Surname").val();
            var message = $("#Message").val();

            if (name && name.length < 2) {
                alert("isim alanı 2 karakterden az olamaz");
                return;
            }
            else if (surname && surname.length < 2) {
                alert("soyisim alanı 2 karakterden az olamaz");
                return;
            }

            else if (message && message.length < 3) {
                alert("mesaj alanı 3 karakterden az olamaz");
                return;
            }

            $("#Contact-Index-Form").hide();
            $("#Contact-Index-Sending").show();

            var data = {
                Name: name,
                Surname=surname,
                Message: message
            };

            $.ajax({

                type: "POST",
                url: "/Contact/Send",
                data: JSON.stringify(data),
                success: Page.Contact.Send_Callback,
                error: Page.Contact.Send_Callback_Error,
                dataType: "json",
                accepts: "application/json",
                contentType:"application/json"
            });
            



        },

        Send_Callback: function (result) {
            $("#Contact-Index-Sending").hide();
            $("#Contact-Index-Sent").show();
            console.log(result);
        },

        Send_Callback_Error: function (request,status,error) {
            $("#Contact-Index-Sending").hide();
            $("#Contact-Index-Sent").hide();
            $("#Contact-Index-Form").show();
            alert("validation error!");

        },

    },
    User: {
        Login: {
            LoginButton: function () {
                var email = $("#Email").val();
                var password = $("#Password").val();

                var data = {
                    Email: email,
                    Password: password
                };

                $.ajax({
                    type: "POST",
                    url: "/User/LoginAction",
                    data: JSON.stringify(data),
                    success: Page.User.Login.LoginButton_Callback,
                    error: Page.User.Login.LoginButton_Callback_Error,
                    dataType: "json",
                    contentType:"application/json"
                });


            },
            LoginButton_Callback: function (result) {
                alert(result);

            },
            LoginButton_Callback_Error: function (request, status, error) {
                console.log(request);
                console.log(status);
                console.log(error);
            }
        }
    }


}