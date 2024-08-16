let idCliente = localStorage.getItem('IdCliente')
localStorage.removeItem('IdCliente')
function Incluir() {
    var formData = $('#formCadastroBeneficiario').serialize();
    formData += '&idCliente=' + encodeURIComponent(idCliente);
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

function loadBeneficiarios() {

    $.ajax({
        type: 'GET',
        url: `/Beneficiarios/Listar`,
        data: { idCliente: localStorage.getItem('idCliente') },
        success: function (data) {
            
            console.log('Beneficiários carregados:', data);
            // Lógica para atualizar a UI com os beneficiários aqui...
        },
        error: function (error) {
            console.error('Erro ao carregar beneficiários:', error);
        }
    })
}













