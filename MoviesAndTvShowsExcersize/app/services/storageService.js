myApp.service('storageService', function () {

    this.Get = function (key) {

        return localStorage.getItem(key);
    }

    this.Set = function (key, value) {

        localStorage.setItem(key, JSON.stringify(value));
    }

    this.Remove = function (key) {

        localStorage.removeItem(key);
    }

});