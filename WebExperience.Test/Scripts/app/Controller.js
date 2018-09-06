app.controller('APIController', function ($scope, APIService) {

    $scope.maxSize = 10;     // Limit number for pagination display number.  
    $scope.totalCount = 0;  // Total number of items in all pages. initialize as a zero  
    $scope.pageIndex = 1;   // Current page number. First page is 1.-->  
    $scope.pageSizeSelected = 10; // Maximum number of items per page.  


    //getAll();

    $scope.getAll = function () {
        var servCall = APIService.getAssets();
        servCall.then(
            function (response) {
                $scope.assets = response.data;
                $scope.totalCount = response.data.length;
                

                var begin = (($scope.pageIndex - 1) * $scope.pageSizeSelected)
                    , end = begin + $scope.pageSizeSelected;

                $scope.filteredAssets = $scope.assets.slice(begin, end);

            },
            function (err) {
                var error = err;
            });
    }

    $scope.getAll();

    //This method is calling from pagination number  
    $scope.pageChanged = function () {
        $scope.getAll();
    };

    $scope.saveAssets = function () {
        var Asset = {
            Asset_Id: $scope.Asset_Id,
            File_Name: $scope.File_Name,
            Mime_Type: $scope.Mime_Type
        };
        console.log("test1");
        var saveAsset = APIService.saveAsset(Asset);
        saveAsset.then(function (d) {
            $scope.getAll();
        }, function (error) {
                console.log('Oops! Something went wrong while saving the data.')
            })
    };   

    $scope.dltAsset = function (Asset_Id) {
        var dlt = APIService.deleteAsset(Asset_Id);
        dlt.then(function (d) {
            console.log("Testing Delete");
            $scope.getAll();
        }, function (error) {
                console.log('Oops! Something went wrong while deleting the data.')
            })
    };   


})   