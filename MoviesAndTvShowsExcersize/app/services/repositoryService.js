myApp.service('repositoryService', function ($http) {

    this.getAll = function (successCallBack, errorCallBack) {

        return $http.get('api/getAllCtrl/getall')
            .then(successCallBack, errorCallBack);
    }

});