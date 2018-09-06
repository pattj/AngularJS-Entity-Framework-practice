app.service("APIService", function ($http) {
    this.getAssets = function () {
        return $http.get("http://localhost:62677/api/Assets")
    }

    this.saveAsset = function (Asset) {
        console.log("test2");
        return $http(
            {
                method: 'POST',
                data: Asset,
                url: "http://localhost:62677/api/Assets"
            });
    }   

    this.deleteAsset = function (AssetId) {
        var url = 'api/Assets/' + AssetId;
        return $http(
            {
                method: 'delete',
                data: AssetId,
                url: url
            });
    }  

});   

 