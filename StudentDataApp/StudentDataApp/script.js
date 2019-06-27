/// <reference path=angular.js" />

var url = "http://localhost:54638/api/students"
var myApp = angular.module("myApp", []);

var MainController = function ($scope, $http) {
    var onSuccess = function (response) { $scope.students = response.data };
    var onFailure = function (reason) { $scope.error = reason};

    var getAllStudents = function () {
        $http.get(url)
        .then(onSuccess, onFailure)
    };
    getAllStudents();
};

myApp.controller("MainController", MainController);