document.addEventListener('DOMContentLoaded', function () {
   
    document.getElementById('Cpf').addEventListener('input', function (e) {
        let value = e.target.value.replace(/\D/g, ''); 
        if (value.length > 11) {
            value = value.slice(0, 11);
        }
        e.target.value = value
            .replace(/(\d{3})(\d{3})/, '$1.$2.')
            .replace(/(\d{3})(\d{2})$/, '$1-$2');
    });

   
    document.getElementById('CEP').addEventListener('input', function (e) {
        let value = e.target.value.replace(/\D/g, ''); 
        if (value.length > 8) {
            value = value.slice(0, 8);
        }
        e.target.value = value
            .replace(/(\d{5})(\d{0,3})/, '$1-$2');
    });

   
    document.getElementById('Telefone').addEventListener('input', function (e) {
        let value = e.target.value.replace(/\D/g, ''); 
        if (value.length > 11) {
            value = value.slice(0, 11);
        }
        e.target.value = value
            .replace(/(\d{2})(\d{0,5})/, '($1) $2')
            .replace(/(\d{5})(\d{0,4})$/, '$1-$2'); 
    });
});

function AbriModalBeneficiarios() {
    var random = Math.random().toString().replace('.', '');
    const texto = `
    <link rel="stylesheet"  href="~/Content/Site.css" asp-append-version="true" />
        <div id="${random}" class="modal fade">
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
                                <input required="required" type="text" class="form-control" id="Cpf" name="Cpf" placeholder="Ex.: 010.011.111-100">
                            </span>
                            <span class="input-nome">
                                <label class="label-cpf" for="Nacionalidade">Nacionalidade:</label>
                                <input required="required" type="text" class="form-control" id="Nacionalidade" name="Nacionalidade" placeholder="Ex.: brasileira" maxlength="50">
                            </span>
                            
                               <span class="btn-incluir">  <button class="btn btn-md btn-success">Incluir</button> </span>
                        </div>
                           
                        </div>
                    </div>
                    <div class="modal-footer">
                        <button type="button" class="btn btn-default" data-dismiss="modal">Fechar</button>
                    </div>
                </div><!-- /.modal-content -->
            </div><!-- /.modal-dialog -->
        </div> <!-- /.modal -->`                                                                                 

    $('body').append(texto);
    $('#' + random).modal('show')
}





    