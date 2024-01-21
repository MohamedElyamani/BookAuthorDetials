$(function () {

    var createModal = new abp.ModalManager(abp.appPath + 'BookAndAuhtorDet/CreateModel');
    var editModal = new abp.ModalManager(abp.appPath + 'BookAndAuhtorDetl/EditModel');


    //Table BookAuthrById
    var dataTableBook = $('#BookTable').DataTable(
        abp.libs.datatables.normalizeConfiguration({
            serverSide: true,
            paging: true,
            order: [[1, "asc"]],
            searching: false,
            scrollX: true,
            ajax: function (data, callback) {
                var authroId = "f73e0813-a476-4763-76a8-3a0f56716252"
                bookAuthorDetials.books.book
                    .getBookByAuthoId(authroId)
                    .then(function (result) {
                        console.log(result);
                        callback({
                            draw: data.draw,
                            recordsTotal: result.totalCount,
                            recordsFiltered: result.totalCount,
                            data: result.items
                        });
                        return abp.libs.datatables.createAjax(result);
                    });
            },
            columnDefs: [
                {
                    title: ('Actions'),
                    rowAction: {
                        items: [
                            {
                                text: ('Edit'),
                                action: function (data) {
                                    editModal.open({ id: data.record.id })
                                }
                            },
                            {
                                text: ('Delete'),
                                confirmMessage: function (data) {
                                    return ('BookDeletionConfirmationMessage', data.record.fristName);
                                },
                                action: function (data) {
                                    bookAuthorDetials.books.book
                                        .delete(data.record.id)
                                        .then(function () {
                                            abp.notify.info(l('SuccessfullyDeleted'));
                                            dataTableBook.ajax.reload();
                                        });

                                }
                            }
                        ]
                    }
                },
                {
                    title: ('Menu:bookName'),
                    data: "bookName"
                },
                {
                    title: ('Menu:authorName'),
                    data: "authorName"
                },

            ]
        })
    );

    $('#NewBookButton').click(function (e) {
        e.preventDefault();
        //alert(' ')
        createModal.open();
    });

    createModal.onResult(function () {
        dataTableBook.ajax.reload();
    });
    editModal.onResult(function () {
        dataTableBook.ajax.reload();
    });



})