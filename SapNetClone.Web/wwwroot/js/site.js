
function openDeleteDialog(id){

    Swal.fire({
        title: 'Do you want to delete the item?',
        showDenyButton: true,
        showCancelButton: true,
        confirmButtonText: 'Delete',
        denyButtonText: `Don't delete`,
    }).then((result) => {
        /* Read more about isConfirmed, isDenied below */
        if (result.isConfirmed) {
            deleteUser(id)
        } else if (result.isDenied) {
            Swal.fire('Cancelled', '', 'info')
        }
    })

}

function deleteUser(paramId) {
    const param = { id: paramId }
   const userElement =  document.getElementById(paramId);

    $.ajax({
        url: "/User/Delete",
        type: "DELETE",
        data: param,
        success: function (result) {
            if (result == "Success") {
                userElement.classList.toggle("fade");
                Swal.fire({
                    position: 'top-end',
                    icon: "success",
                    title: result,
                    showConfirmButton: false,
                    timer: 1500
                })
            }
            
        }
    })
}