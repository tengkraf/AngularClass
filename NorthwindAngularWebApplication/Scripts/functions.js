    function clearForm() {

        var elements = document.body.getElementsByTagName('input');
        for (var i = 0; i < elements.length; i++) {
            elements[i].value = "";
        }
    }