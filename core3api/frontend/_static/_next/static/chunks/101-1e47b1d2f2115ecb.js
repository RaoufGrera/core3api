"use strict";(self.webpackChunk_N_E=self.webpackChunk_N_E||[]).push([[101],{4441:function(e,t,n){n.d(t,{f:function(){return v}});var r=n(4051),o=n.n(r),s=n(5893),i=n(3253),l=n.n(i),a=n(7294),c=n(7536),u=n(1650),d=n(150),m=n(8638),p=n(1752),f=(n(4524),n(782));function h(e,t){(null==t||t>e.length)&&(t=e.length);for(var n=0,r=new Array(t);n<t;n++)r[n]=e[n];return r}function b(e,t,n,r,o,s,i){try{var l=e[s](i),a=l.value}catch(c){return void n(c)}l.done?t(a):Promise.resolve(a).then(r,o)}function y(e,t){return function(e){if(Array.isArray(e))return e}(e)||function(e,t){var n=null==e?null:"undefined"!==typeof Symbol&&e[Symbol.iterator]||e["@@iterator"];if(null!=n){var r,o,s=[],i=!0,l=!1;try{for(n=n.call(e);!(i=(r=n.next()).done)&&(s.push(r.value),!t||s.length!==t);i=!0);}catch(a){l=!0,o=a}finally{try{i||null==n.return||n.return()}finally{if(l)throw o}}return s}}(e,t)||function(e,t){if(!e)return;if("string"===typeof e)return h(e,t);var n=Object.prototype.toString.call(e).slice(8,-1);"Object"===n&&e.constructor&&(n=e.constructor.name);if("Map"===n||"Set"===n)return Array.from(n);if("Arguments"===n||/^(?:Ui|I)nt(?:8|16|32)(?:Clamped)?Array$/.test(n))return h(e,t)}(e,t)||function(){throw new TypeError("Invalid attempt to destructure non-iterable instance.\\nIn order to be iterable, non-array objects must have a [Symbol.iterator]() method.")}()}var C=(0,p.default)().publicRuntimeConfig,g="".concat(C.imgUrl);function v(e){var t=(0,u.$G)().t,n=e.show,r=e.change,i=e.exit,p=e.id,h=(0,c.cI)(),C=(h.register,h.handleSubmit),v=(h.reset,h.formState,(0,a.useState)("")),w=v[0],x=v[1],j=y(a.useState(0),2),O=j[0],k=j[1],A=(0,a.useState)(!1),N=A[0],S=A[1],E=(0,a.useState)("/Stamp/deafult.png"),D=E[0],P=E[1],I=function(){var e,n=(e=o().mark((function e(n){return o().wrap((function(e){for(;;)switch(e.prev=e.next){case 0:n.preventDefault(),d.QT.sendAsk({ask:w,Stamp:D,CountChar:O},p).then((function(e){console.log("result",e),x(""),k(0),r(e),f.Am.success(t("send_new_ask"))})),i(),console.log("Sbumit");case 4:case"end":return e.stop()}}),e)})),function(){var t=this,n=arguments;return new Promise((function(r,o){var s=e.apply(t,n);function i(e){b(s,r,o,i,l,"next",e)}function l(e){b(s,r,o,i,l,"throw",e)}i(void 0)}))});return function(e){return n.apply(this,arguments)}}();return(0,s.jsx)("div",{children:(0,s.jsx)(l(),{isOpen:n,contentLabel:"onRequestClose Example",ariaHideApp:!1,className:"dialog-input open aside",overlayClassName:"Overlay",children:(0,s.jsxs)("div",{className:"container-modal open ",children:[(0,s.jsx)("div",{id:"headerMessage",children:(0,s.jsxs)("div",{class:"row w-100 m-0",children:[(0,s.jsx)("div",{class:"col-1 d-flex align-items-center mx-1 p-0",children:(0,s.jsx)("button",{onClick:i,type:"button",class:"btn btn-default btn-toolbar",children:t("close")})}),(0,s.jsx)("div",{class:"col d-flex flex-row-reverse align-items-center text-right pr-1",children:(0,s.jsxs)("button",{onClick:I,type:"button",class:"btn btn-dark ml-2 btn-120",children:[(0,s.jsx)("i",{class:"icon-send mr-2",children:(0,s.jsx)("svg",{xmlns:"http://www.w3.org/2000/svg",width:"16",height:"16",fill:"currentColor",class:"bi bi-send",viewBox:"0 0 16 16",children:(0,s.jsx)("path",{d:"M15.854.146a.5.5 0 0 1 .11.54l-5.819 14.547a.75.75 0 0 1-1.329.124l-3.178-4.995L.643 7.184a.75.75 0 0 1 .124-1.33L15.314.037a.5.5 0 0 1 .54.11ZM6.636 10.07l2.761 4.338L14.13 2.576 6.636 10.07Zm6.787-8.201L1.591 6.602l4.339 2.76 7.494-7.493Z"})})}),(0,s.jsx)("span",{children:t("send")})]})})]})}),(0,s.jsx)(m.s,{id:p,show:N,exit:function(){S(!1)},change:function(e){P(e)}}),(0,s.jsxs)("div",{class:"d-flex pt-2 px-3 align-items-center",children:[(0,s.jsx)("div",{class:"d-flex align-items-center mt-n2"}),(0,s.jsx)("div",{class:"flex-grow-1 text-dir text-start",children:(0,s.jsx)("button",{onClick:function(){S(!0)},class:"btn btn-default pr-2",children:(0,s.jsx)("img",{class:"stamp loaded",width:100,src:"".concat(g,"/").concat(D)})})})]}),(0,s.jsx)("form",{className:"form-msg",onSubmit:C((function(e){console.log("Sbumit data")})),children:(0,s.jsx)("fieldset",{className:"fade style-list",children:(0,s.jsx)("textarea",{placeholder:t("write_question"),onChange:function(e){x(e.target.value),k(e.target.value.length)},rows:"9",value:w||""})})})]})})})}},827:function(e,t,n){var r=n(7294);function o(e,t){if(null==e)return{};var n,r,o=function(e,t){if(null==e)return{};var n,r,o={},s=Object.keys(e);for(r=0;r<s.length;r++)n=s[r],t.indexOf(n)>=0||(o[n]=e[n]);return o}(e,t);if(Object.getOwnPropertySymbols){var s=Object.getOwnPropertySymbols(e);for(r=0;r<s.length;r++)n=s[r],t.indexOf(n)>=0||Object.prototype.propertyIsEnumerable.call(e,n)&&(o[n]=e[n])}return o}function s(){return s=Object.assign||function(e){for(var t=1;t<arguments.length;t++){var n=arguments[t];for(var r in n)Object.prototype.hasOwnProperty.call(n,r)&&(e[r]=n[r])}return e},s.apply(this,arguments)}function i(e,t){var n=Object.keys(e);if(Object.getOwnPropertySymbols){var r=Object.getOwnPropertySymbols(e);t&&(r=r.filter((function(t){return Object.getOwnPropertyDescriptor(e,t).enumerable}))),n.push.apply(n,r)}return n}function l(e){for(var t=1;t<arguments.length;t++){var n=null!=arguments[t]?arguments[t]:{};t%2?i(Object(n),!0).forEach((function(t){a(e,t,n[t])})):Object.getOwnPropertyDescriptors?Object.defineProperties(e,Object.getOwnPropertyDescriptors(n)):i(Object(n)).forEach((function(t){Object.defineProperty(e,t,Object.getOwnPropertyDescriptor(n,t))}))}return e}function a(e,t,n){return t in e?Object.defineProperty(e,t,{value:n,enumerable:!0,configurable:!0,writable:!0}):e[t]=n,e}const c={breakpointCols:void 0,className:void 0,columnClassName:void 0,children:void 0,columnAttrs:void 0,column:void 0};class u extends r.Component{constructor(e){let t;super(e),this.reCalculateColumnCount=this.reCalculateColumnCount.bind(this),this.reCalculateColumnCountDebounce=this.reCalculateColumnCountDebounce.bind(this),t=this.props.breakpointCols&&this.props.breakpointCols.default?this.props.breakpointCols.default:parseInt(this.props.breakpointCols)||2,this.state={columnCount:t}}componentDidMount(){this.reCalculateColumnCount(),window&&window.addEventListener("resize",this.reCalculateColumnCountDebounce)}componentDidUpdate(){this.reCalculateColumnCount()}componentWillUnmount(){window&&window.removeEventListener("resize",this.reCalculateColumnCountDebounce)}reCalculateColumnCountDebounce(){window&&window.requestAnimationFrame?(window.cancelAnimationFrame&&window.cancelAnimationFrame(this._lastRecalculateAnimationFrame),this._lastRecalculateAnimationFrame=window.requestAnimationFrame((()=>{this.reCalculateColumnCount()}))):this.reCalculateColumnCount()}reCalculateColumnCount(){const e=window&&window.innerWidth||1/0;let t=this.props.breakpointCols;"object"!==typeof t&&(t={default:parseInt(t)||2});let n=1/0,r=t.default||2;for(let o in t){const s=parseInt(o);s>0&&e<=s&&s<n&&(n=s,r=t[o])}r=Math.max(1,parseInt(r)||1),this.state.columnCount!==r&&this.setState({columnCount:r})}itemsInColumns(){const e=this.state.columnCount,t=new Array(e),n=r.Children.toArray(this.props.children);for(let r=0;r<n.length;r++){const o=r%e;t[o]||(t[o]=[]),t[o].push(n[r])}return t}renderColumns(){const{column:e,columnAttrs:t={},columnClassName:n}=this.props,o=this.itemsInColumns(),i=100/o.length+"%";let a=n;a&&"string"!==typeof a&&(this.logDeprecated('The property "columnClassName" requires a string'),"undefined"===typeof a&&(a="my-masonry-grid_column"));const c=l(l(l({},e),t),{},{style:l(l({},t.style),{},{width:i}),className:a});return o.map(((e,t)=>r.createElement("div",s({},c,{key:t}),e)))}logDeprecated(e){console.error("[Masonry]",e)}render(){const e=this.props,{children:t,breakpointCols:n,columnClassName:i,columnAttrs:l,column:a,className:c}=e,u=o(e,["children","breakpointCols","columnClassName","columnAttrs","column","className"]);let d=c;return"string"!==typeof c&&(this.logDeprecated('The property "className" requires a string'),"undefined"===typeof c&&(d="my-masonry-grid")),r.createElement("div",s({},u,{className:d}),this.renderColumns())}}u.defaultProps=c},4849:function(e,t,n){n.d(t,{Z:function(){return i}});var r=n(7294);const o=r.createContext({});function s({baseColor:e,highlightColor:t,width:n,height:r,borderRadius:o,circle:s,direction:i,duration:l,enableAnimation:a=true}){const c={};return"rtl"===i&&(c["--animation-direction"]="reverse"),"number"===typeof l&&(c["--animation-duration"]=`${l}s`),a||(c["--pseudo-element-display"]="none"),"string"!==typeof n&&"number"!==typeof n||(c.width=n),"string"!==typeof r&&"number"!==typeof r||(c.height=r),"string"!==typeof o&&"number"!==typeof o||(c.borderRadius=o),s&&(c.borderRadius="50%"),"undefined"!==typeof e&&(c["--base-color"]=e),"undefined"!==typeof t&&(c["--highlight-color"]=t),c}function i({count:e=1,wrapper:t,className:n,containerClassName:i,containerTestId:l,circle:a=!1,style:c,...u}){var d,m;const p=r.useContext(o),f={...u};for(const[r,o]of Object.entries(u))"undefined"===typeof o&&delete f[r];const h={...p,...f,circle:a},b={...c,...s(h)};let y="react-loading-skeleton";n&&(y+=` ${n}`);const C=null!==(d=h.inline)&&void 0!==d&&d,g=[];for(let o=0;o<e;o++){const e=r.createElement("span",{className:y,style:b,key:o},"\u200c");C?g.push(e):g.push(r.createElement(r.Fragment,{key:o},e,r.createElement("br",null)))}return r.createElement("span",{className:i,"data-testid":l,"aria-live":"polite","aria-busy":null===(m=h.enableAnimation)||void 0===m||m},t?g.map(((e,n)=>r.createElement(t,{key:n},e))):g)}}}]);