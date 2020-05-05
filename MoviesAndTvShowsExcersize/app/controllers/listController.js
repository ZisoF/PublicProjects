myApp.controller('listController', function ($scope, $filter, repositoryService, storageService) {

    $scope.dataList = [];
    $scope.sortBy = "-1";

    $scope.ErrMsg = null;

    $scope.isError = false;
    $scope.noData = false;

    $scope.init = function () {

        repositoryService.getAll(getAllSuccessCallBack, getAllErrorCallBack);
    }
    $scope.sortArray = function () {

        switch ($scope.sortBy) {

            case 'Title':

                $scope.dataList.sort(function (a, b) {
                    if (a.Title < b.Title) { return -1; }
                    if (a.Title > b.Title) { return 1; }
                    return 0;
                });

                break;

            case 'Views':

                $scope.dataList.sort(function (a, b) {
                    if (a.Views > b.Views) { return -1; }
                    if (a.Views < b.Views) { return 1; }
                    return 0;
                });

                break;

            case 'Seasson':

                $scope.dataList.sort(function (a, b) {
                    if (a.Seasson > 0 && b.Seasson == 0) { return -1; }
                    if (a.Seasson < b.Seasson) { return -1; }
                    if (a.Seasson > b.Seasson) { return 1; }
                    return 0;
                });

                break;

            default:

                $scope.sortBy = "-1";
                break;
        }

    }
    $scope.setItem = function (id) {
        storageService.Set('itemDescription', $filter('filter')($scope.dataList, { Id: id }, true)[0]);
    }

    function getAllSuccessCallBack(response) {

        if (response.data.ErrObj && response.data.ErrObj.IsError) {

            $scope.ErrMsg = response.data.ErrObj.ErrMessage;
            $scope.dataList = null;
            $scope.isError = true;
            return;
        }

        $scope.ErrMsg = null;
        $scope.isError = false;

        if (response.data.Data && response.data.Data.length == 0) {

            $scope.noData = true;
            $scope.dataList = [];
            return;
        }

        $scope.noData = false;

        $scope.dataList = JSON.parse(response.data.Data).repository;
    }
    function getAllErrorCallBack(error) {

        console.log(error);
        $scope.ErrMsg = 'Error Occured!';
    }
});