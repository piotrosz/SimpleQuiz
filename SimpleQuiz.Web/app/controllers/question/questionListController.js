﻿'use strict';

quizApp.controller("QuestionListController", function ($scope, quizService, toaster, $routeParams, $modal, $controller, modalService) {

    init();

    function init()
    {
        $scope.quizId = $routeParams.quizId;

        getQuiz(true);
    }

    function getQuiz(shouldExpandAll)
    {
        quizService.get($scope.quizId,
            function (result) {
                $scope.quiz = result;
                if(shouldExpandAll) {
                    expandAll();
                }

                angular.forEach($scope.quiz.CategoryQuestions, function (value, key) {
                    value.AnswersGrouped = _.groupBy(value.Answers, "Category");
                });
            },
            function (result) {

            });
    }

    function expandAll()
    {
        $scope.areOpenQuestionsCollapsed = true;
        $scope.areTestQuestionsCollapsed = true;
        $scope.areCategoryQuestionsCollapsed = true;
        $scope.areSortQuestionsCollapsed = true;
    }

    $scope.openAddModal = function(questionType)
    {
        var question = {
            QuizId: $scope.quizId,
            Content: "",
            View: "Standard",
        };

        switch(questionType)
        {
            case "Open":
                question.Answers = [{ OrderId: 1, CorrectAnswerOptions: [{ Content: "" }] }];
                break;
            case "Test":
                question.Answers = [{ Content: "", IsCorrect: false}];
                break;
            case "Category":
                question.Answers = [{ Category: "", Content: "", OrderId: 1}];
                break;
            case "Sort":
                question.Answers = [{ Content: "", OrderId: 1}]
                break;
        }

        var modalInstance = $modal.open({
            templateUrl: modalService.getModalTemplateUrl("question/" + questionType, "add"),
            controller: modalService.getModalControllerName(questionType + "Question"),
            resolve: {
                question: function () { return question }
            }
        });

        modalInstance.result.then(function () {
            getQuiz();
        });
    }

    $scope.openEditModal = function(questionType, question)
    {
        var modalInstance = $modal.open({
            templateUrl: modalService.getModalTemplateUrl("question/" + questionType, "edit"),
            controller: modalService.getModalControllerName(questionType + "Question"),
            resolve: {
                question: function () { return question; }
            }
        });

        modalInstance.result.then(function () {
            getQuiz();
        });
    }

    $scope.openDeleteModal = function(questionType, question)
    {
        var modalInstance = $modal.open({
            templateUrl: modalService.getModalTemplateUrl("question/", "delete"),
            controller: modalService.getModalControllerName(questionType + "Question"),
            resolve: {
                question: function () { return question; }
            }
        });

        modalInstance.result.then(function () {
            getQuiz();
        }, function () {
            // Do nothing when dismissed 
        });
    }
});