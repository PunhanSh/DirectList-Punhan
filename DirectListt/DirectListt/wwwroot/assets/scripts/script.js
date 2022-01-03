$(document).ready(function () {

    let submit = $("#submitBtn");

    submit.click(function (e) {
        e.preventDefault();

        let email = $("#mc4wp-form-1 input[name='email']")
        let first = $("#mc4wp-form-1 input[name='firstname']")
        let last = $("#mc4wp-form-1 input[name='lastname']")
        let subject = $("#mc4wp-form-1 input[name='subject']")
        let message = $("#mc4wp-form-1 input[name='message']")
        let success = $("#mc4wp-form-1 alert-success")
        let warning = $("#mc4wp-form-1 alert-warning")
        success.css("display", "none")
        warning.css("display", "none")

        $ajax({
            url: "Contact/SendMessage",
            type: "get",
            dataType: "json",
            data: {
                email: email.val()
            },
            success: function (response) {
                if (response.status == true) {
                    success.css("display", "block");
                    success.text(response.message);
                } else {
                    warning.css("display", "block");
                    warning.text(response.message);
                }
            },
            error: function (error) {
                console.log(error);
            },
            complete: function () {
                email.val("")
            }
        })
        $ajax({
            url: "Contact/SendMessage",
            type: "get",
            dataType: "json",
            data: {
                first: first.val()
            },
            success: function (response) {
                if (response.status == true) {
                    success.css("display", "block");
                    success.text(response.message);
                } else {
                    warning.css("display", "block");
                    warning.text(response.message);
                }
            },
            error: function (error) {
                console.log(error);
            },
            complete: function () {
                first.val("")
            }
        })
        $ajax({
            url: "Contact/SendMessage",
            type: "get",
            dataType: "json",
            data: {
                last: last.val()
            },
            success: function (response) {
                if (response.status == true) {
                    success.css("display", "block");
                    success.text(response.message);
                } else {
                    warning.css("display", "block");
                    warning.text(response.message);
                }
            },
            error: function (error) {
                console.log(error);
            },
            complete: function () {
                last.val("")
            }
        })
        $ajax({
            url: "Contact/SendMessage",
            type: "get",
            dataType: "json",
            data: {
                subject: subject.val()
            },
            success: function (response) {
                if (response.status == true) {
                    success.css("display", "block");
                    success.text(response.message);
                } else {
                    warning.css("display", "block");
                    warning.text(response.message);
                }
            },
            error: function (error) {
                console.log(error);
            },
            complete: function () {
                subject.val("")
            }
        })
        $ajax({
            url: "Contact/Message",
            type: "get",
            dataType: "json",
            data: {
                message: message.val()
            },
            success: function (response) {
                if (response.status == true) {
                    success.css("display", "block");
                    success.text(response.message);
                } else {
                    warning.css("display", "block");
                    warning.text(response.message);
                }
            },
            error: function (error) {
                console.log(error);
            },
            complete: function () {
                message.val("")
            }
        })


        }
    )


    }
)