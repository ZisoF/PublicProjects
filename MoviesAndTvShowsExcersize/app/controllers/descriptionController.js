myApp.controller('descriptionController', function ($scope, storageService) {

    $scope.data = null;

    $scope.init = function () {

        $scope.data = JSON.parse(storageService.Get('itemDescription'));
    }

    $scope.$on('$destroy', function iVeBeenDismissed() {

        storageService.Remove('itemDescription');
    });
});