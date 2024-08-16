document.addEventListener('DOMContentLoaded', function () {
   
    document.getElementById('Cpf').addEventListener('input', function (e) {
        let value = e.target.value.replace(/\D/g, '') 
        if (value.length > 11) {
            value = value.slice(0, 11)
        }
        e.target.value = value
            .replace(/(\d{3})(\d{3})/, '$1.$2.')
            .replace(/(\d{3})(\d{2})$/, '$1-$2')
    })

    document.getElementById('cpfBeneficiario').addEventListener('input', function (e) {
        let value = e.target.value.replace(/\D/g, '')
        if (value.length > 11) {
            value = value.slice(0, 11)
        }
        e.target.value = value
            .replace(/(\d{3})(\d{3})/, '$1.$2.')
            .replace(/(\d{3})(\d{2})$/, '$1-$2')
    })
    

   
    document.getElementById('CEP').addEventListener('input', function (e) {
        let value = e.target.value.replace(/\D/g, '') 
        if (value.length > 8) {
            value = value.slice(0, 8)
        }
        e.target.value = value
            .replace(/(\d{5})(\d{0,3})/, '$1-$2')
    })

   
    document.getElementById('Telefone').addEventListener('input', function (e) {
        let value = e.target.value.replace(/\D/g, '') 
        if (value.length > 11) {
            value = value.slice(0, 11)
        }
        e.target.value = value
            .replace(/(\d{2})(\d{0,5})/, '($1) $2')
            .replace(/(\d{5})(\d{0,4})$/, '$1-$2') 
    })
   
})

