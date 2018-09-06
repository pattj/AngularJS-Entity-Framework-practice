 
/* 
var app = angular.module('AssetsList', ['ui.bootstrap']);

app.controller('assetCtrl',  function ($scope, $http, $location, $routeParams) {

    $scope.maxSize = 10;     // Limit number for pagination display number.  
    $scope.totalCount = 0;  // Total number of items in all pages. initialize as a zero  
    $scope.pageIndex = 1;   // Current page number. First page is 1.-->  
    $scope.pageSizeSelected = 10; // Maximum number of items per page.  

    

    $scope.getAssetList = function () {
        $http.get("http://localhost:62677/api/Assets").then(
            function (response) {
                $scope.assets = response.data;
                $scope.totalCount = response.data.length; 
                console.log(response.data.length);

                var begin = (($scope.pageIndex - 1) * $scope.pageSizeSelected)
                    , end = begin + $scope.pageSizeSelected;

                $scope.filteredAssets = $scope.assets.slice(begin, end);

            },
            function (err) {
                var error = err;
            });
    }

    //Loading employees list on first time  
    $scope.getAssetList();

    //This method is calling from pagination number  
    $scope.pageChanged = function () {
        $scope.getAssetList();
    };



});   
*/
 