var config = [{
    id: 'userrule',
    menu: [{
        text: '用户管理',
        items: [
            { id: 'users-list', text: '账号列表', href: 'userrule/users/list.html', closeable: false },
            { id: 'users-name', text: '真实姓名审核', href: 'userrule/main/menu.html' },
            { id: 'activation-code', text: '邀请码管理', href: 'userrule/main/second-menu.html' },
            { id: 'users-register', text: '用户注册管理', href: 'userrule/main/second-menu.html' },
            { id: 'ip-list', text: 'IP限制白名单管理', href: 'userrule/main/second-menu.html' },
            { id: 'device-list', text: '设备码白名单管理', href: 'userrule/main/second-menu.html' },
        ]
    }, {
        text: '子账号管理',
        items: [
            { id: 'subaccount', text: '子账号列表', href: 'userrule/subaccount/list.html' },
        ]
    }, {
        text: '层级管理',
        items: [
            { id: 'hierarchy', text: '层级管理列表', href: 'userrule/hierarchy/list.html' },
        ]
    }, {
        text: '会员分析系统',
        items: [
            { id: 'userinfo', text: '会员概况', href: 'userrule/useranalysis/userinfo.html' },
            { id: 'user-login', text: '登录历史记录', href: 'userrule/hierarchy/list.html' },
            { id: 'ip-audit', text: 'IP稽核', href: 'userrule/hierarchy/list.html' },
            { id: 'user-profit', text: '用户盈利排行榜', href: 'userrule/hierarchy/list.html' },
        ]
    }, {
        text: '白名单管理',
        items: [
            { id: 'white-ip', text: '白名单管理', href: 'userrule/whiteip/list.html' }
        ]
    }]
}, {
    id: 'bankcard',
    menu: [{
        text: '厅主银行卡管理',
        items: [
            { id: 'code', text: '银行账户设定', href: 'cashsystem/bankcard/accountset.html' },
            { id: 'alipayaccount', text: '支付宝设定', href: 'cashsystem/bankcard/alipayaccount.html' },
            { id: 'wechataccount', text: '微信账号设定', href: 'cashsystem/bankcard/wechataccount.html' },
            { id: 'cyberbank', text: '网银支付设定', href: 'cashsystem/bankcard/cyberbank.html' },
            { id: 'jdpay', text: '京东支付设定', href: 'cashsystem/bankcard/jdpay.html' },
            { id: 'unionPay', text: '银联支付设定', href: 'cashsystem/bankcard/unionPay.html' },
            { id: 'wechatpolling', text: '微信个人账号轮询设定', href: 'cashsystem/bankcard/wechatpolling.html' },
            { id: 'alipaypolling', text: '支付宝个人账号轮询设定', href: 'cashsystem/bankcard/alipaypolling.html' },
            { id: 'paysort', text: '支付方式排序', href: 'cashsystem/bankcard/paysort.html' }
        ]
    }, {
        text: '入款管理',
        items: [
            { id: 'depends', text: '银行账号', href: 'form/depends.html' },
            { id: 'depends', text: '支付宝', href: 'form/depends.html' },
            { id: 'depends', text: '微信账号', href: 'form/depends.html' },
            { id: 'depends', text: '网银支付', href: 'form/depends.html' },
            { id: 'depends', text: '京东支付', href: 'form/depends.html' },
            { id: 'depends', text: '银联支付', href: 'form/depends.html' },
            { id: 'depends', text: '强制入款记录', href: 'form/depends.html' },
        ]
    }, {
        text: '出款管理',
        items: [
            { id: 'depends', text: '出款详情', href: 'form/depends.html' },
            { id: 'depends', text: '自动出款设定', href: 'form/depends.html' },
        ]
    }, {
        text: '会员账目明细',
        items: [
            { id: 'depends', text: '会员余额变更明细', href: 'form/depends.html' },
            { id: 'depends', text: '会员出入款账目查询', href: 'form/depends.html' },
        ]
    }, {
        text: '层级支付设定',
        items: [
            { id: 'depends', text: '默认支付方式', href: 'form/depends.html' },
            { id: 'depends', text: '自定义支付方式设定', href: 'form/depends.html' },
        ]
    }, {
        text: '人工提存',
        items: [
            { id: 'depends', text: '人工存入', href: 'form/depends.html' },
            { id: 'depends', text: '人工提出', href: 'form/depends.html' },
            { id: 'depends', text: '修改打码量', href: 'form/depends.html' },
            { id: 'depends', text: '人工存提历史查询', href: 'form/depends.html' },
        ]
    }]
}, {
    id: 'search',
    menu: [{
        text: '注单管理',
        items: [

        ]
    }, {
        text: '彩种设定',
        items: [
            { id: 'code', text: '高频彩', href: 'detail/code.html' },
            { id: 'code', text: '低频彩', href: 'detail/code.html' }
        ]
    }, {
        text: '开奖结果',
        items: [
            { id: 'code', text: '当前开奖时间查询', href: 'detail/code.html' },
            { id: 'code', text: '历史开奖结果查询', href: 'detail/code.html' }
        ]
    }]
}, {
    id: 'detail',
    menu: [{
        text: '详情页面',
        items: [
            { id: 'code', text: '详情页面代码', href: 'detail/code.html' },
            { id: 'example', text: '详情页面示例', href: 'detail/example.html' },
            { id: 'introduce', text: '详情页面简介', href: 'detail/introduce.html' }
        ]
    }]
}, {
    id: 'chart',
    menu: [{
        text: '彩票报表总概',
        items: [
            { id: 'code', text: '引入代码', href: 'chart/code.html' },
        ]
    }, {
        text: '个人报表',
        items: [
            { id: 'code', text: '实时查询', href: 'chart/code.html' },
            { id: 'code', text: '历史统计', href: 'chart/code.html' }
        ]
    }, {
        text: '团队报表',
        items: [
            { id: 'code', text: '历史统计', href: 'chart/code.html' },
        ]
    }, {
        text: '出入款账目汇总',
        items: [
            { id: 'code', text: '出入款账目汇总', href: 'chart/code.html' },
        ]
    }, {
        text: '公司报表',
        items: [
            { id: 'code', text: '公司报表', href: 'chart/code.html' },
        ]
    }]
}, {
    id: 'site',
    menu: [{
        text: '网站管理',
        items: [
            { id: 'code', text: '全局设定', href: 'chart/code.html' },
            { id: 'code', text: '公告', href: 'chart/code.html' },
            { id: 'code', text: '全局设定', href: 'chart/code.html' },
            { id: 'code', text: '活动文案', href: 'chart/code.html' },
            { id: 'lotteryplay', text: '彩票玩法', href: 'site/lotteryplay.html' },
            { id: 'code', text: '消息发送', href: 'chart/code.html' },
            { id: 'feedback', text: '意见反馈', href: 'site/feedback.html' },
            { id: 'code', text: '域名管理', href: 'chart/code.html' },
        ]
    }]
}, {
    id: 'activity',
    menu: [{
        text: '优惠活动',
        items: [
            { id: 'code', text: '注册优惠设定', href: 'chart/code.html' },
            { id: 'code', text: '反水优惠设定', href: 'chart/code.html' },
            { id: 'code', text: '红包活动', href: 'chart/code.html' }
        ]
    }]
},];
(function ($) {

  var baseUrl = '',         //网站的根目录地址，发布到线上时使用
    jsBase = '/assets/js';
  
  function isRelative(url){
    if(!/:/.test(url)){
      return true;
    }
  }
  function formatUrl(url){
    if(isRelative(url)){
      var path = getCurrentPath();
      return path +'/'+ url;
    }
    return url;
  }
  function getCurrentPath(){
    var url = location.href,
      lastIndex;
    url = url.replace(/\?.*$/,'').replace(/\#.*$/,'');
    lastIndex = url.lastIndexOf('/');
    return url.substring(0,lastIndex);
  }
  function getBaseUrl(){    //根据config.js的路径取baseUrl
    var scripts = $('script'),
      rst = '';
    $.each(scripts,function(index,script){
      var src = script.src,
        lastIndex = src.indexOf(jsBase + '/config');
      if(lastIndex !== -1){
        rst = src.substring(0,lastIndex);
        return false;
      }
    });
    return formatUrl(rst);
  }

  if(!baseUrl){//如果未指定项目路径，进行匹配。
    baseUrl = getBaseUrl();
    baseUrl =  baseUrl.replace(/(.*)\/$/,'$1');
  }

  BUI.config({
    alias : {
      'common' : baseUrl + jsBase + '/common',
      'module' : baseUrl + jsBase + '/module'
    }/*,
    map : [ //调试环境下使用'*.js'，如果发布上线前，使用*-min.js去掉下面的map
      [/common\/(.*)-min.js/,'common/$1.js'],
      [/module\/(.*)-min.js/,'module/$1.js']
    ]*/
    
  });

})(jQuery);