
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

$(document).ready(function () {
    // Apply mask to both main form and modal CPF inputs
    $('.cpf-mask').mask('000.000.000-00');
   
});













