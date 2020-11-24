$(function () {
    var l = abp.localization.getResource('Erp');

    var createModal = new abp.ModalManager(abp.appPath + "Productos/CreateModal");

    var editModal = new abp.ModalManager(abp.appPath + "Productos/EditModal");

    var dataTable = $('#ProductosTabla').DataTable(
        abp.libs.datatables.normalizeConfiguration({
            serverSide: true,
            paging: true,
            order: [[1, "asc"]],
            searching: false,
            scrollX: true,
            ajax: abp.libs.datatables.createAjax(someCompany.erp.productos.producto.getList),
            columnDefs: [
                {
                    title: "Crud",
                    rowAction: {
                        items: [
                            {
                                text: l("Edit"),
                                action: function (data) {
                                    editModal.open({ id: data.record.id })
                                }
                            },
                            {
                                text: l("Delete"),
                                confirmMessage: function (data) {
                                    return "Quieres eliminar el Producto '" + data.record.nombre + "'";
                                },
                                action: function (data) {
                                    someCompany.erp.productos.producto.delete(data.record.id).then(function () {
                                        abp.notify.info("Eliminado!!");

                                        dataTable.ajax.reload();
                                    });
                                }
                            }
                        ]
                    },
                },
                {
                    title: l("Name"),
                    data: "nombre"
                },
                {
                    title: l("Code"),
                    data: "codigoProducto"
                },
                {
                    title: l("Enabled"),
                    data: "isDeleted",
                    render: function (data) {
                        return data ? "Deshabilitado" : "Habilidado"
                    }
                },
                {
                    title: "Creación",
                    data: "creationTime",
                    render: function (data) {
                        return luxon.DateTime.fromISO(data, {
                            locale: abp.localization.currentCulture.name
                        }).toLocaleString(luxon.DateTime.DATETIME_SHORT);
                    }
                }
            ]
        })
    );

    createModal.onResult(function () {
        dataTable.ajax.reload();
    });

    editModal.onResult(function () {
        dataTable.ajax.reload();
    });

    $("#NuevoProducto").click(function (e) {
        e.preventDefault();

        createModal.open();
    });
});