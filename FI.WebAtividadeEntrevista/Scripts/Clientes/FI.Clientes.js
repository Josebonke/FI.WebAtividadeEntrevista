﻿
$(document).ready(function () {
    $('#formCadastro').submit(function (e) {
        e.preventDefault();
        $.ajax({
            url: urlPost,
            method: "POST",
            data: {
                "NOME": $(this).find("#Nome").val(),
                "CEP": $(this).find("#CEP").val(),
                "Email": $(this).find("#Email").val(),
                "Cpf": $(this).find("#Cpf").val(),
                "Sobrenome": $(this).find("#Sobrenome").val(),
                "Nacionalidade": $(this).find("#Nacionalidade").val(),
                "Estado": $(this).find("#Estado").val(),
                "Cidade": $(this).find("#Cidade").val(),
                "Logradouro": $(this).find("#Logradouro").val(),
                "Telefone": $(this).find("#Telefone").val(),
                
            },


            error:
                function (r) {
                    if (r.status == 400)
                        ModalDialog("Aviso", r.responseJSON);
                    else if (r.status == 500)
                        ModalDialog("Ocorreu um erro", "Ocorreu um erro interno no servidor.");

                },
            success:
                function (r) {                    
                    localStorage.setItem('idCliente', r.Id)
                    ModalDialog("Sucesso!", `#${r.Id}-${r.Nome} Cadastrado`)
                    $('#modalBeneficiarios').modal('show');
                    $("#formCadastro")[0].reset();
                   
                   
                }
        });
    })

})




function ModalDialog(titulo, texto) {
    var random = Math.random().toString().replace('.', '');
    var modalHTML = `
        <div id="${random}" class="modal fade">                                                              
            <div class="modal-dialog">                                                                                 
                <div class="modal-content">                                                                            
                    <div class="modal-header">                                                                         
                        <button type="button" class="close" data-dismiss="modal" aria-hidden="true">×</button>         
                        <h4 class="modal-title">${titulo}</h4>                                                   
                    </div>                                                                                             
                    <div class="modal-body">                                                                           
                        <p>${texto}</p>                                                                             
                    </div>                                                                                             
                    <div class="modal-footer">                                                                         
                        <button type="button" class="btn btn-default" data-dismiss="modal">Fechar</button>             
                    </div>                                                                                             
                </div><!-- /.modal-content -->                                                                         
            </div><!-- /.modal-dialog -->                                                                                    
        </div> <!-- /.modal -->
    `;

    $('body').append(modalHTML);
    $('#' + random).modal('show');
}
