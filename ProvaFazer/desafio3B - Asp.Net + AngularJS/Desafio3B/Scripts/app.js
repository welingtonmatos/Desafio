angular.module('app', ["ngMaterial"]);

angular.module('app').controller('AppController', function ($scope, $http) {
    $scope.alimentos = [
        { Nome: 'Exemplo fixo 1', Preco: 30, Quantidade: 1 },
        { Nome: 'Exemplo fixo 2', Preco: 60, Quantidade: 2 },
    ];


    $scope.buscarAlimentos = function (termo) {
        return $http.get('http://localhost:59266/listacompra/buscarAlimentos?termo=' + termo)
            .then(function (response) {
                return response.data;
            })
            .catch(function (response) {
                console.log(response);
                alert("Erro ao buscar alimento");
            });
    };

    $scope.total = function () {
        //NotImplemented
    }

    $scope.add = function () {

        //Aumentar a quantidade caso insira novamente um mesmo alimento
        //Implementar aqui...
    }

    $scope.remover = function () {
        if (confirm("Tem certeza que deseja remover?")) {
            //Implementar aqui o codigo de remover...
        }
    }

    $scope.salvar = function () {
        //NotImplemented
    }
});