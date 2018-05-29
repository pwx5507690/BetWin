var url = "/Page/Query/AccountsBankInfo";
var respository = "AccountsBankInfo";

var data = [];
var getCurrentById = function (id) {
    for (var i = 0; i < data.length; i++) {
        if (id == data[i]["id"])
            return data[i];
    }
};
var Grid = BUI.Grid,
    Store = BUI.Data.Store,
    columns = [
        { title: '账户名称', width: 100, sortable: false, dataIndex: 'accounts' },
        { title: '开户银行', width: 100, sortable: true, selectable: true, dataIndex: 'bankName' },
        { title: '银行代号', width: 150, sortable: false, selectable: true, dataIndex: 'bankCode' },
        { title: '银行地址', width: 100, sortable: true, showTip: true, dataIndex: 'bankAddress' },
        { title: '银行卡号', width: 100, sortable: true, showTip: true, dataIndex: 'bankNum' },
        { title: '银行开户名称', width: 100, sortable: true, dataIndex: 'bankUserName' },
        {
            title: '更新时间', width: 100, sortable: true, dataIndex: 'addDate', renderer: function (value, obj) {
                return convetToTime(value);
            }
        },
        {
            title: '操作', width: 300, dataIndex: 'g', renderer: function (value, obj) {
                data.push(obj);
                return '<span class="grid-command button" onclick="update(\'' + obj.id + '\')">修改</span><span class="grid-command button" onclick="del(\'' + obj.id + '\')">删除</span>';
            }
        }
    ];
var store = new Store({
    url: url,
    autoLoad: true,
    pageSize: 10
}),
    grid = new Grid.Grid({
        render: '#grid',
        loadMask: true,
        forceFit: true,
        columns: columns,
        store: store,
        plugins: [Grid.Plugins.AutoFit], //勾选插件、自适应宽度插件
        // 顶部工具栏
        bbar: {
            //items 也可以在此配置
            // pagingBar:表明包含分页栏
            pagingBar: true
        }
    });
grid.render();
//创建表单，表单中的日历，不需要单独初始化
var form = new BUI.Form.HForm({
    srcNode: '#searchForm'
}).render();

form.on('beforesubmit', function (ev) {
    //BUI.use('bui/form', function (Form) {
    //    new Form.Form({
    //        srcNode: '#J_Form'
    //    }).render();
    //});
    //BUI.FormHelper.setFields(form, data);
    //序列化成对象
    var obj = form.serializeToObject();
    obj.start = 0; //返回第一页
    store.load(obj);
    return false;
});
function closed() {
    this.close();
    // 因为dialog 每次会加载 删除 dialog
};
function validateBankCard(num, code, id, message, callbcak) {
    var expModel = { bankNum: "'" + num + "'", bankCode: "'" + code + "'" };
    if (id)
        expModel.id = "_not_ " + id;
    var expression = JSON.stringify({ bankNum: "'" + num + "'", bankCode: "'" + code + "'" });
    var url = "QueryExist/AccountsBankInfo?expression=" + encodeURIComponent(expression);
    send({
        url: url,
        type: "get",
        dataType: "html",
        success: function (result) {
            console.log(result);
            if (result == "False") {
                callbcak && callbcak();
            } else {
                message.Alert('卡号已经存在', 'error');
            }
        }
    });
};
function addhandler(message) {
    var validate = validateForm($("#accountsBankInfoForm"));
    if (!validate)
        return;
    var self = this;
    var item = BUI.FormHelper.serializeToObject(document.getElementById("accountsBankInfoForm"));
    validateBankCard(item.bankNum, item.bankCode, null, message, function () {
        var postModel = getPostModel("AddStr", "AccountsBankInfo", JSON.stringify(item));
        self.close();
        send({
            url: "option",
            data: postModel,
            type: "post",
            success: function (result) {
                message.Show({
                    msg: '添加成功',
                    icon: 'success',
                    buttons: [],
                    autoHide: true,
                    autoHideDelay: 1000
                });
                store.load();
            },
            error: function () {
                message.Alert('添加失败', 'error');
            }
        });
    });
};
function updatehandler(message, id) {
    var validate = validateForm($("#accountsBankInfoForm"));
    if (!validate)
        return;
    var self = this;
    var item = BUI.FormHelper.serializeToObject(document.getElementById("accountsBankInfoForm"));
    item.id = id;
    validateBankCard(item.bankNum, item.bankCode, id, message, function () {
        var postModel = getPostModel("updateStr", "AccountsBankInfo", JSON.stringify(item));
        self.close();
        send({
            url: "option",
            data: postModel,
            type: "post",
            success: function (result) {
                message.Show({
                    msg: '修改成功',
                    icon: 'success',
                    buttons: [],
                    autoHide: true,
                    autoHideDelay: 1000
                });
                store.load();
            },
            error: function () {
                message.Alert('修改失败', 'error');
            }
        });
    });
};
function optionModal(param) {
    BUI.use('bui/overlay', function (Overlay) {
        var dialog = new Overlay.Dialog({
            title: param.title,
            width: 450,
            height: 300,
            mask: true,
            closeAction: 'destroy',
            bodyContent: param.content,
            buttons: [
                {
                    text: '确定',
                    elCls: 'button button-primary',
                    handler: function () {
                        if (param.optionType == "add")
                            addhandler.call(this, BUI.Message);
                        else
                            updatehandler.call(this, BUI.Message, param.currentId);
                    }
                },
                {
                    text: '取消',
                    elCls: 'button',
                    handler: closed
                }
            ]
        });
        console.log(dialog.width);
        dialog.show();
    });
};
function update(id) {
    var item = getCurrentById(id);
    optionModal({
        currentId: id,
        optionType: "update",
        title: "修改",
        content: $("#formTemp").html()
    });
    form = document.getElementById("accountsBankInfoForm");
    BUI.FormHelper.setFields(form, item);
    $("#accountsInfo").val(item.userID);
    $("#bankType").val(item.bankCode);
};
function add() {
    optionModal({
        optionType: "add",
        title: "新增银行账户",
        content: $("#formTemp").html()
    });
};
function delhandler(message) {
    var item = getCurrentById(id);
    var postModel = getPostModel("DeleteStr", "AccountsBankInfo", JSON.stringify(item));
    this.close();
    send({
        url: "option",
        data: postModel,
        type: "post",
        success: function () {
            message.Show({
                msg: '删除成功',
                icon: 'success',
                buttons: [],
                autoHide: true,
                autoHideDelay: 1000
            });
            store.load();
        },
        error: function () {
            message.Alert('删除失败', 'error');
        }
    });
};
function del(id) {
    BUI.use('bui/overlay', function (overlay) {
        BUI.Message.Show({
            title: '',
            msg: '确认删除吗该选项?',
            icon: 'question',
            buttons: [
                {
                    text: '确定',
                    elCls: 'button button-primary',
                    handler: function () {
                        delhandler.call(this, BUI.Message);
                    }
                },
                {
                    text: '取消',
                    elCls: 'button',
                    handler: closed
                }
            ]
        });
    });
};
$(function () {
    $(document).on("change", "#accountsInfo", function () {
        var $this = $(this);
        $("#userID").val($this.val());
        $("#accounts").val($this.find("option:selected").text());
    })
        .on("change", "#bankType", function () {
            var $this = $(this);
            $("#bankCode").val($this.val());
            $("#bankName").val($this.find("option:selected").text());
        });
});