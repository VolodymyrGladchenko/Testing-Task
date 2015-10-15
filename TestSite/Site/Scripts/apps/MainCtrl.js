var app = angular.module('uigrid', ['ngTouch', 'ui.grid', 'ui.grid.edit']);

app.controller('MainCtrl', ['ProductsService', '$scope', function (ProductsService, $scope) {
    $scope.sort = [];
    $scope.filter = [];
    $scope.pagination = {
        pageSize: 10,
        pageNumber: 1,
        totalItems: null,
        getTotalPages: function () {
            return Math.ceil(this.totalItems / this.pageSize);
        },
        nextPage: function () {
            if (this.pageNumber < this.getTotalPages()) {
                this.pageNumber++;
                $scope.load();
            }
        },
        previousPage: function () {
            if (this.pageNumber > 1) {
                this.pageNumber--;
                $scope.load();
            }
        }
    };

    $scope.gridOptions = {
        enablePaginationControls: false,
        useExternalSorting: true,
        useExternalFiltering: true,
        enableFiltering: true,
        onRegisterApi: function (gridApi) {
            $scope.gridApi = gridApi;

            //declare the events
            $scope.gridApi.core.on.sortChanged($scope, function (grid, sortColumns) {
                $scope.sort = [];
                angular.forEach(sortColumns, function (sortColumn) {
                    $scope.sort.push({
                        fieldName: sortColumn.name,
                        order: sortColumn.sort.direction
                    });
                });
                $scope.load();
            });

            $scope.gridApi.core.on.filterChanged($scope, function () {
                $scope.filter = [];

                var grid = this.grid;
                angular.forEach(grid.columns, function (column) {
                    var fieldName = column.field;
                    var value = column.filters[0].term;
                    var operator = "contains";
                    if (value) {
                        if (fieldName == "id") operator = "equals";
                        else if (fieldName == "price") operator = "greaterThanOrEqualsTo";
                        $scope.filter.push({
                            fieldName: fieldName,
                            operator: operator,
                            value: value
                        });
                    }
                });

                $scope.load();
            });

            $scope.gridApi.edit.on.afterCellEdit($scope, function (rowEntity, colDef, newValue, oldValue) {
                var id = rowEntity.Id;
                var data = {};
                data[colDef.name] = newValue;

                ProductsService.update(id, data).then(function (response) {
                    $scope.load(); //The change may trigger other server side action that may change additional data
                    $scope.$apply();
                });
            });
        }
    };

    $scope.gridOptions.columnDefs = [
        { name: 'firstname', displayName: 'Name', width: '20%' },
        { name: 'lastName', displayName: 'LastName', width: '20%' },
        { name: 'email', displayName: 'Email', width: '30%' },
        { name: 'phone', displayName: 'Phone', width: '20%' }

    ];


    $scope.load = function () {
        ProductsService.readAll($scope.pagination.pageSize, $scope.pagination.pageNumber, $scope.sort, $scope.filter).then(function (response) {
            $scope.gridOptions.data = response.Data.Users;
            $scope.pagination.totalItems = response.TotalRows;

        });
    };

    $scope.load();
}]);


(function () {

    angular.module('uigrid')
        .service('ProductsService', ['$http', ProductsService]);

    function ProductsService($http) {

        var self = this;
        var baseUrl = 'http://localhost:50134/api/';
      
        var objectName = 'users';

        self.readAll = function (pageSize, pageNumber, sort, filter) {
            return $http({
                method: 'GET',
                url: baseUrl + objectName,
                params: {
                    pageSize: pageSize,
                    pageNumber: pageNumber,
                    sort: sort,
                    filter: filter
                },
            }).then(function (response) {
                return response.data;
            });
        };

        self.readOne = function (id) {
            return $http({
                method: 'GET',
                url: baseUrl + objectName + '/' + id,
            }).then(function (response) {
                return response.data;
            });
        };

        self.create = function (data) {
            return $http({
                method: 'POST',
                url: baseUrl + objectName,
                data: data,
                params: {
                    returnObject: true
                },
            }).then(function (response) {
                return response.data;
            });
        };

        self.update = function (id, data) {
            return $http({
                method: 'PUT',
                url: baseUrl + objectName + '/' + id,
                data: data,
            }).then(function (response) {
                return response.data;
            });
        };

        self.delete = function (id) {
            return $http({
                method: 'DELETE',
                url: baseUrl + objectName + '/' + id,
            });
        };

    }
}());