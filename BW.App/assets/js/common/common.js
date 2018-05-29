var convetToTime = function (value) {
    return value.replace(/T/g, ' ').replace(/\.[\d]{3}Z/, '');
};
var getPostModel = function (cmd, respository, content) {
    return {
        cmd: cmd,
        respository: respository,
        content: content
    };
};
var validateForm = function (form) {
    var isvalidate = true;
    form.find("input,select").each(function () {
        var item = $(this);
        var span = item.next("span");
        if (span.length > 0) {
            span.hide();
            var value = item.val();
            if (!value || value == "-1") {
                isvalidate = false;
                span.show();
            }
        }
    });
    return isvalidate;
};
var isNumber = function (value) {
    var patrn = /^[0-9]*$/;
    return !(patrn.exec(value) == null || value == "");
};
var convertToExpression = function (expressionModel) {
    var clone = new Object();
    for (var item in expressionModel) {
        if (isNumber(expressionModel[item]))
            clone[item] = expressionModel[item];
        else
            clone[item] = "'" + expressionModel[item]+"'";
    }
    return clone;
};
var send = function (param) {
    var url = "/page/";
    $.ajax({
        url: url + param.url,
        dataType: param.dataType || "json",
        type: param.type,
        data: param.data,
        success: function (result) {
            param.success && param.success(result);
        },
        error: function () {
            param.error && param.error(result);
        }
    });
};