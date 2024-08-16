 let idCliente = localStorage.getItem('idCliente')
function Incluir() {
    var formData = $('#formCadastroBeneficiario').serialize();

    $.ajax({
        type: 'POST',
        url: '/Beneficiarios/Incluir',
        data: formData,
        success: function (result) {
            // Tratar a resposta do servidor
            alert('Beneficiário incluído com sucesso!');
            $('#modalBeneficiarios').modal('hide');

            ModalDialog('titulo', 'texto')
        },
       
           
        error: function (error) {
            // Tratar erros
            alert('Erro ao incluir beneficiário!');
        }

    });    

}

function loadBeneficiarios(idCliente) {

    $.ajax({
        type: 'GET',
        url: `/Beneficiarios/Listar`, // URL do endpoint
        data: { idCliente: localStorage.getItem('idCliente') }, // Passando idCliente via query string
        success: function (data) {
            // Atualizar o conteúdo do modal com os dados dos beneficiários
            console.log('Beneficiários carregados:', data);
            // Lógica para atualizar a UI com os beneficiários aqui...
        },
        error: function (error) {
            console.error('Erro ao carregar beneficiários:', error);
        }
    })
}













