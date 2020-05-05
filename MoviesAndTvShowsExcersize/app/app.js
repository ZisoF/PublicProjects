var myApp = angular.module('myApp', ["ngRoute"])
    .config(function ($routeProvider) {
    $routeProvider
        .when("/", {
            templateUrl: "app/templates/List.htm",
            controller: "listController"
        })
        .when("/List", {
            templateUrl: "app/templates/List.htm",
            controller: "listController"
        })
        .when("/Description", {
            templateUrl: "app/templates/Description.htm",
            controller: "descriptionController"
        });
});
