
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
        },
       
           
                error: function (error) {
                    // Tratar erros
                    alert('Erro ao incluir beneficiário!');
                }

            });

    

}

function ModalDialogApontamentoBeneficiario() {
    var random = Math.random().toString().replace('.', '');
    var texto = `
       
            <div class="modal fade" id="confirmModal" tabindex="-1" role="dialog" aria-labelledby="confirmModalLabel" aria-hidden="true">
                <div class="modal-dialog" role="document">
                    <div class="modal-content">
                        <div class="modal-header">
                            <h5 class="modal-title" id="confirmModalLabel">Confirmação</h5>
                            <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                <span aria-hidden="true">&times;</span>
                            </button>
                        </div>
                        <div class="modal-body">
                            <p>Deseja cadastrar Beneficiários?</p>
                        </div>
                        <div class="modal-footer">
                            <button type="button" id="btnSim" onclick="opcaoSim()" class="btn-sm  btn-success">Sim</button>
                            <button type="button" class="btn btn-sm btn-danger" data-dismiss="modal">Não</button>
                        </div>
                    </div>
                </div>
            </div>            `

    $('body').append(texto);
    $('#' + 'confirmModal').modal('show');
}

function opcaoSim() {
    ModalDialogBeneficiario()
    $('#formCadastroBeneficiario').modal('hide');
}


function ModalDialogBeneficiario() {
    const formTemplate = `
    <form id="formCadastroBeneficiarios" method="post">
    <div id="modalBeneficiarios" class="modal fade">
        <div class="modal-dialog">
            <div class="dialog-content">
                <div class="dialog-header">
                    <h4 class="modal-title">Beneficiários</h4>
                    <button type="button" class="close" data-dismiss="modal" aria-hidden="true">×</button>
                </div>
                <div class="dialog-body">
                    <div class="dialog-form-group">
                        <span class="input-cpf">
                            <label class="label-cpf" for="cpf">CPF:</label>
                            <input required="required"
                                   type="text"
                                   class="form-control"
                                   id="cpfBeneficiario"
                                   name="cpfBeneficiario"
                                   placeholder="Ex.: 010.011.111-100" maxlength="15">
                        </span>
                        <span class="input-nome">
                            <label class="label-cpf" for="Nome">Nome:</label>
                            <input required="required"
                                   type="text"
                                   class="form-control"
                                   id="Nome"
                                   name="Nome"
                                   placeholder="Ex.: João Souza"
                                   maxlength="50">
                        </span>
                        <span class="btn-incluir">
                            <button type="submit"  class="btn btn-primary">Incluir</button>
                        </span>
                    </div>
                </div>
                </form>
                <div class="modal-footer">
                    <button type="button" class="btn btn-default" data-dismiss="modal">Fechar</button>
                </div>
            </div>
        </div>
    </div>
    `;

    $('body').append(formTemplate);

    // Ative o modal
    $('#modalBeneficiarios').modal('show');

    // Associe o evento ao campo CPF
    $('#cpfBeneficiario').on('input', function (e) {

        let value = e.target.value.replace(/\D/g, '');
        if (value.length > 11) {
            value = value.slice(0, 11);
        }
        e.target.value = value
            .replace(/(\d{3})(\d{3})/, '$1.$2.')
            .replace(/(\d{3})(\d{2})$/, '$1-$2');
    });
}






