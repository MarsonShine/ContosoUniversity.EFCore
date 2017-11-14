// Write your JavaScript code.
//<div class="container">
//    <ul class="list">
//        <li class="item">1</li>
//        <li class="item">2</li>
//        <li class="item">3</li>
//        <li class="item">4</li>
//    </ul>
//</div>
//核心原理：js事件触发的冒泡原理
//当你点击图上的li.item的时候，li会第一个触发，之后紧接着触发li的父级元素ul
//同理，ul触发结束后又紧接着触发ul的父级元素div，div.container触发之后又寻找div有没有父级元素
//如果存在，则继续“冒泡”，否则停止触发整个系列事件
document.querySelector('.container ul').click = function (e) {
    //那么触发这么多次事件，如何选择自己想要的点击事件呢？、
    //在这里想要获取li的点击事件，所以就得通过e.target来判断
    //e.target这个的意思是当前被点击的元素
    var target = e.target;
    if (!!target) {
        //判断该目标是否是你想要的li元素，只需要判断这个target的节点可行是li，class=item即可(当然如果其他地方也有同名的话，你可以加个其他标识)
        if (target.nodeName == "LI" && target.className == "item") {
            alert("li.item被点击了");
        } else {
            alert("不是div.container ul li.item被点击了");
        }
    }
}

function on(eventName, elements, callback) {
    if (!selector) return false;
    //selector.addEventListener(eventName, , true);
    var params = elements.split(' ');
    var selectorRootTarget = document.body;
    for (var i = 0; i < params.length-1; i++) {
        selectorRootTarget = selectorRootTarget.querySelector(params[i]);
    }
    function internalFunction() {

    }
}

