(self.webpackChunk_N_E=self.webpackChunk_N_E||[]).push([[170],{4274:function(e,s,n){(window.__NEXT_P=window.__NEXT_P||[]).push(["/users/indexonline",function(){return n(4523)}])},4523:function(e,s,n){"use strict";n.r(s);var i=n(5893),c=n(7294),t=n(150),l=(0,n(1752).default)().publicRuntimeConfig,r="".concat(l.imgUrl);s.default=function(){var e=(0,c.useState)(null),s=e[0],n=e[1],l=(0,c.useState)(null),a=l[0],d=l[1];return(0,c.useEffect)((function(){t.QT.getAll().then((function(e){n(e)}));var e=localStorage.getItem("user");console.log("pageChange Appsss",e);var s=JSON.parse(e);t.QT.createHubConnection(s.token),console.log(" accountService.onlineUserstValue();",t.QT.onlineUserstValue)}),[]),(0,c.useEffect)((function(){var e=t.QT.onlineUsers.subscribe((function(e){d(e)}));return function(){return e.unsubscribe()}}),[]),(0,i.jsxs)("div",{children:[(0,i.jsx)("div",{className:"col-md-3"}),(0,i.jsxs)("div",{className:"col-md-9",children:[(0,i.jsx)("h1",{children:"Users"}),(0,i.jsx)("h2",{children:a}),s&&a&&s.map((function(e){return(0,i.jsxs)("div",{className:"cv-div",children:[" ",(0,i.jsxs)("div",{className:"cv-body",children:[(0,i.jsx)("div",{className:"devimgseeker",children:(0,i.jsx)("a",{title:e.name,href:"/user/"+e.id,children:(0,i.jsx)("img",{className:"imgseeker-view",src:"".concat(r,"/").concat(e.image)})})}),(0,i.jsxs)("table",{children:[(0,i.jsxs)("tr",{children:[" ",(0,i.jsxs)("td",{height:"30",children:[(0,i.jsx)("h2",{children:(0,i.jsx)("a",{title:e.name,id:"cvname",href:"/user/"+e.id,children:e.name})}),(0,i.jsxs)("span",{class:"texts",children:[e.aboutMe," \xa0"]}),(0,i.jsx)("hr",{})]})]}),(0,i.jsx)("tr",{children:(0,i.jsx)("td",{children:(0,i.jsxs)("span",{title:"Chat Now","data-test-selector":"chat_link",children:[(0,i.jsx)("a",{class:"status",icon:"app_online",children:"\xa0"}),(0,i.jsx)("span",{class:"stylesB__LastOnlineAt-fuiQxB status-title",children:a.includes(e.userName)?"Online":"Offline"})]})})})]})]})]},e.id)})),!s&&(0,i.jsx)("tr",{children:(0,i.jsx)("td",{colSpan:"4",className:"text-center",children:(0,i.jsx)("div",{className:"spinner-border spinner-border-lg align-center"})})}),s&&!s.length&&(0,i.jsx)("tr",{children:(0,i.jsx)("td",{colSpan:"4",className:"text-center",children:(0,i.jsx)("div",{className:"p-2",children:"No Users To Display"})})})]})]})}}},function(e){e.O(0,[774,888,179],(function(){return s=4274,e(e.s=s);var s}));var s=e.O();_N_E=s}]);