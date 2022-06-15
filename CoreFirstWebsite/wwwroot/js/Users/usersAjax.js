function getAllUsers() {
    $.ajax('https://localhost:44368/api/userModels',
        {
        type: 'GET',
        dataType: 'json', // type of response data
        success: function (data, status, xhr) {   // success callback function
            //data est un tableau,donc je peut faire un foreach
            $("#AllUsers").empty();
            data.forEach(user => {
                let nom = user.name;
                let prenom = user.surname;
                let naissance = user.dateNaissance;

                $("#AllUsers").append("<p>"+nom+" "+prenom+"</p>")
            });
        },
        error: function (jqXhr, textStatus, errorMessage) { // error callback 
            alert(errorMessage);
        }
    });
}

function createUser() {
    //Récupère les valeurs du formulaire
    let nomInput = $("#NomUser").val();
    let prenomInput = $("#PrenomUser").val();

    //Le body de notre requête 
    let formData = {
        "name": nomInput,
        "surname": prenomInput
    };

    //On lance la requête
    $.ajax('https://localhost:44368/api/userModels',
        {
            type: 'POST',
            dataType: 'json', // type of response data
            headers: {
                "Content-Type": "application/json"
            },
            data: JSON.stringify(formData),
            success: function (data, status, xhr) {   // success callback function
                getAllUsers();
            },
            error: function (jqXhr, textStatus, errorMessage) { // error callback 
                alert(errorMessage);
            }
        });
}


function getAllTodoItems() {
    $.ajax('https://localhost:44368/api/todoItems',
        {
            dataType: 'json', // type of response data
            success: function (data, status, xhr) {   // success callback function
                //data est un tableau,donc je peut faire un foreach
                $("#AllTodoItems").empty();
                data.forEach(user => {
                    let nom = user.name;

                    $("#AllTodoItems").append("<p>" + nom + "</p>")

                });
            },
            error: function (jqXhr, textStatus, errorMessage) { // error callback 
                alert(errorMessage);
            }
        });
}

function createItem() {
    //Récupère les valeurs du formulaire
    let nomInput = $("#ItemName").val();
    let isComplete = $("#ItemComplete").is(':checked');

    //Le body de notre requête 
    let formData = {
        "name": nomInput,
        "isComplete": isComplete
    };

    //On lance la requête
    $.ajax('https://localhost:44368/api/todoItems',
        {
            type: 'POST',
            dataType: 'json', // type of response data
            headers: {
                "Content-Type": "application/json"
            },
            data: JSON.stringify(formData),
            success: function (data, status, xhr) {   // success callback function
                getAllTodoItems();
            },
            error: function (jqXhr, textStatus, errorMessage) { // error callback 
                alert(errorMessage);
            }
        });
}