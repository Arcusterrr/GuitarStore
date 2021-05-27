(this.webpackJsonpreactadminnet=this.webpackJsonpreactadminnet||[]).push([[0],{374:function(e,t,a){},432:function(e,t,a){},507:function(e,t,a){"use strict";a.r(t);var r=a(4),c=a(0),n=a.n(c),s=a(16),i=a.n(s),o=(a(374),a(11)),j=a(611),u=a(593),b=a(592),l=a(136),d=a.n(l),O=a(177),m=a(287),x="/admin/api/v1",p="/admin/api/v1/account/signIn",f="6Ld6decaAAAAAEKI7xRO7U__e-FFjrB8febEm1vR",h=a(69);function g(e){var t=arguments.length>1&&void 0!==arguments[1]?arguments[1]:{};t.headers||(t.headers=new Headers);var a=localStorage.getItem("token");return t.headers.set("Authorization","Bearer ".concat(a)),h.a.fetchJson(e,t)}var v=Object(m.a)(x,g),w=Object(o.a)(Object(o.a)({},v),{},{create:function(e,t){if(console.log(e),"guitars"!==e)return v.create(e,t);var a=new FormData;return a.append("name",t.data.name),a.append("description",t.data.description),a.append("rating",t.data.rating),a.append("count",t.data.count),a.append("cost",t.data.cost),a.append("guitarTypeId",t.data.guitarTypeId),a.append("files",t.data.image.rawFile),t.data.files.forEach((function(e){return a.append("files",e.rawFile)})),g("".concat(x,"/").concat(e),{method:"POST",body:a}).then((function(e){var a=e.json;return{data:Object(o.a)(Object(o.a)({},t.data),{},{id:a.id})}}))},update:function(e,t){var a,r;if("guitars"!==e)return v.update(e,t);var c=new FormData;return c.append("name",t.data.name),c.append("description",t.data.description),c.append("rating",t.data.rating),c.append("count",t.data.count),c.append("cost",t.data.cost),c.append("guitarTypeId",t.data.guitarTypeId),c.append("files",null===(a=t.data.image)||void 0===a?void 0:a.rawFile),null===(r=t.data.files)||void 0===r||r.forEach((function(e){return c.append("files",e.rawFile)})),g("".concat(x,"/").concat(e,"/").concat(t.id),{method:"PUT",body:c}).then((function(e){var a=e.json;return{data:Object(o.a)(Object(o.a)({},t.data),{},{id:a.id})}}))}}),y={login:function(e){var t=e.username,a=e.password,r=e.captchaResult,c=new Request(p,{method:"POST",body:JSON.stringify({username:t,password:a}),headers:new Headers({"Content-Type":"application/json",CaptchaResponse:r})});return fetch(c).then((function(e){if(e.status<200||e.status>=300)throw new Error("\u041d\u0435\u043f\u0440\u0430\u0432\u0438\u043b\u044c\u043d\u044b\u0439 \u043b\u043e\u0433\u0438\u043d \u0438\u043b\u0438 \u043f\u0430\u0440\u043e\u043b\u044c");return e.json()})).then((function(e){var t=e.data,a=t.accessToken,r=t.roles;T(a,r)}))},logout:function(){return C(),Promise.resolve()},checkError:function(e){var t=e.status;return 401===t||403===t?(C(),Promise.reject()):Promise.resolve()},checkAuth:function(){return I()?Promise.resolve():Promise.reject()},getPermissions:function(){var e=S();return e?Promise.resolve(JSON.parse(e)):Promise.resolve([])}},I=function(){return localStorage.getItem("token")},S=function(){return localStorage.getItem("permissions")},C=function(){localStorage.removeItem("token"),localStorage.removeItem("permissions")},T=function(e,t){localStorage.setItem("token",e),localStorage.setItem("permissions",JSON.stringify(t))},k=a(182),P=a(185),F=a(36),D=a(570),N=a(516),R=a(568),E=a(571),A=a(123),J=a(49),_=a(569),B=a(98),L=a(164),q=a(332),z=Object(A.a)((function(e){return{form:{padding:"0 1em 1em 1em"},input:{marginTop:"1em"},button:{width:"100%"},icon:{marginRight:e.spacing(1)}}}),{name:"RaLoginForm"}),H=function(e){var t=e.meta,a=t.touched,c=t.error,n=e.input,s=Object(P.a)(e,["meta","input"]);return Object(r.jsx)(R.a,Object(o.a)(Object(o.a)(Object(o.a)({error:!(!a||!c),helperText:a&&c},n),s),{},{fullWidth:!0}))},U=c.createRef(),K=function(e){var t=Object(J.a)(!1),a=Object(k.a)(t,2),c=a[0],n=a[1],s=Object(_.a)(),i=Object(B.a)(),o=Object(L.a)(),j=z(e);return Object(r.jsx)("div",{children:Object(r.jsx)(F.b,{onSubmit:function(e){n(!0),s(e).then((function(){n(!1)})).catch((function(e){n(!1),o("string"===typeof e?e:"undefined"!==typeof e&&e.message?e.message:"ra.auth.sign_in_error","warning")}))},validate:function(e){var t={username:void 0,password:void 0};return e.username||(t.username=i("ra.validation.required")),e.password||(t.password=i("ra.validation.required")),t},render:function(e){var t,a=e.handleSubmit;return Object(r.jsxs)("form",{onSubmit:function(e){e.preventDefault(),U.current.execute()},noValidate:!0,children:[Object(r.jsxs)("div",{className:j.form,children:[Object(r.jsx)("div",{className:j.input,children:Object(r.jsx)(F.a,{autoFocus:!0,id:"username",name:"username",component:H,label:i("ra.auth.username"),disabled:c})}),Object(r.jsx)("div",{className:j.input,children:Object(r.jsx)(F.a,{id:"password",name:"password",component:H,label:i("ra.auth.password"),type:"password",disabled:c,autoComplete:"current-password"})}),Object(r.jsx)(F.a,{name:"captchaResult",component:(t=function(){a(),U.current.reset()},function(e){return Object(r.jsx)(q.a,{ref:U,size:"invisible",sitekey:f,onChange:function(a){e.input.onChange(a),t()}})})})]}),Object(r.jsx)(D.a,{children:Object(r.jsxs)(N.a,{variant:"contained",type:"submit",color:"primary",disabled:c,className:j.button,children:[c&&Object(r.jsx)(E.a,{className:j.icon,size:18,thickness:2}),i("ra.auth.sign_in")]})})]})}})})},M=(a(432),a(293)),V=a.n(M),W=a(294),G=a.n(W),Q=a(331),X=Object(Q.a)({palette:{primary:V.a,secondary:G.a}}),Y=a(595),Z=a(594),$=a(583),ee=a(584),te=function(e){return Object(r.jsx)(Y.a,Object(o.a)(Object(o.a)({},e),{},{title:"\u0421\u043f\u0438\u0441\u043e\u043a \u043f\u043e\u043b\u044c\u0437\u043e\u0432\u0430\u0442\u0435\u043b\u0435\u0439",sort:{field:"registrationDate",order:"DESC"},children:Object(r.jsxs)(Z.a,{rowClick:"show",isRowSelectable:function(){return!1},children:[Object(r.jsx)($.a,{label:"\u0418\u043c\u044f \u043f\u043e\u043b\u044c\u0437\u043e\u0432\u0430\u0442\u0435\u043b\u044f",source:"userName"}),Object(r.jsx)(ee.a,{label:"\u0414\u0430\u0442\u0430 \u0440\u0435\u0433\u0438\u0441\u0442\u0440\u0430\u0446\u0438\u0438",source:"registrationDate"})]})}))},ae=a(600),re=a(586),ce=function(e){return Object(r.jsx)(ae.a,Object(o.a)(Object(o.a)({},e),{},{children:Object(r.jsxs)(re.a,{children:[Object(r.jsx)($.a,{label:"\u041b\u043e\u0433\u0438\u043d",source:"userName"}),Object(r.jsx)(ee.a,{label:"\u0414\u0430\u0442\u0430 \u0440\u0435\u0433\u0438\u0441\u0442\u0440\u0430\u0446\u0438\u0438",source:"registrationDate"})]})}))},ne=a(587),se=function(e){return Object(r.jsx)(Y.a,Object(o.a)(Object(o.a)({},e),{},{title:"\u0421\u043f\u0438\u0441\u043e\u043a \u0433\u0438\u0442\u0430\u0440",sort:{field:"dateCreated",order:"DESC"},children:Object(r.jsxs)(Z.a,{rowClick:"show",isRowSelectable:function(){return!1},children:[Object(r.jsx)($.a,{label:"\u041d\u0430\u0437\u0432\u0430\u043d\u0438\u0435",source:"name"}),Object(r.jsx)(ee.a,{label:"\u0414\u0430\u0442\u0430 \u0441\u043e\u0437\u0434\u0430\u043d\u0438\u044f",source:"dateCreated"}),Object(r.jsx)(ne.a,{render:function(e){return Object(r.jsx)("img",{height:300,style:{objectFit:"cover",objectPosition:"center"},width:300,src:e.img})}})]})}))},ie=a(606),oe=function(e){return Object(r.jsx)(ae.a,Object(o.a)(Object(o.a)({},e),{},{children:Object(r.jsxs)(re.a,{children:[Object(r.jsx)($.a,{label:"\u041d\u0430\u0437\u0432\u0430\u043d\u0438\u0435",source:"name"}),Object(r.jsx)($.a,{label:"\u041e\u043f\u0438\u0441\u0430\u043d\u0438\u0435",source:"description"}),Object(r.jsx)($.a,{label:"\u0426\u0435\u043d\u0430",source:"cost"}),Object(r.jsx)($.a,{label:"\u041a\u043e\u043b\u0438\u0447\u0435\u0441\u0442\u0432\u043e",source:"count"}),Object(r.jsx)($.a,{label:"\u0420\u0435\u0439\u0442\u0438\u043d\u0433",source:"rating"}),Object(r.jsx)(ie.a,{label:"\u0422\u0438\u043f \u0433\u0438\u0442\u0430\u0440\u044b",source:"guitarTypeId",reference:"guitartypes",children:Object(r.jsx)($.a,{source:"name"})}),Object(r.jsx)(ee.a,{label:"\u0414\u0430\u0442\u0430 \u0440\u0435\u0433\u0438\u0441\u0442\u0440\u0430\u0446\u0438\u0438",source:"dateCreated"}),Object(r.jsx)(ne.a,{label:"\u0424\u043e\u0442\u043e",render:function(e){return Object(r.jsx)("img",{width:300,src:e.img})}}),Object(r.jsx)(ne.a,{label:"\u0414\u0435\u0442\u0430\u043b\u044c\u043d\u044b\u0435 \u0444\u043e\u0442\u043e",render:function(e){return Object(r.jsx)(r.Fragment,{children:e.detailedImages.map((function(e){return Object(r.jsx)("img",{width:300,src:e})}))})}})]})}))},je=a(86),ue=a(603),be=a(596),le=a(609),de=a(313),Oe=a(601),me=a(602),xe=a(598),pe=a(589),fe=function(e){return Object(r.jsx)(ue.a,Object(o.a)(Object(o.a)({},e),{},{children:Object(r.jsxs)(be.a,{children:[Object(r.jsx)(le.a,{label:"\u041d\u0430\u0437\u0432\u0430\u043d\u0438\u0435",source:"name",validate:Object(de.d)()}),Object(r.jsx)(le.a,{label:"\u041e\u043f\u0438\u0441\u0430\u043d\u0438\u0435",source:"description",validate:Object(de.d)()}),Object(r.jsx)(le.a,{label:"\u0426\u0435\u043d\u0430",source:"cost",validate:[Object(de.d)(),Object(de.c)(1),Object(de.b)(3e6)]}),Object(r.jsx)(le.a,{label:"\u041a\u043e\u043b\u0438\u0447\u0435\u0441\u0442\u0432\u043e",source:"count",validate:[Object(de.d)(),Object(de.c)(1),Object(de.b)(100)]}),Object(r.jsx)(le.a,{label:"\u0420\u0435\u0439\u0442\u0438\u043d\u0433",source:"rating",validate:[Object(de.d)(),Object(de.c)(0),Object(de.b)(10)]}),Object(r.jsx)(Oe.a,{label:"\u0422\u0438\u043f \u0433\u0438\u0442\u0430\u0440\u044b",source:"guitarTypeId",reference:"guitartypes",validate:Object(de.d)(),children:Object(r.jsx)(me.a,{optionText:"name"})}),Object(r.jsx)(xe.a,{source:"image",label:"\u041a\u0430\u0440\u0442\u0438\u043d\u043a\u0430",multiple:!1,validate:Object(de.d)(),children:Object(r.jsx)(he,{source:"src"})}),Object(r.jsx)(xe.a,{source:"files",label:"\u0414\u0435\u0442\u0430\u043b\u044c\u043d\u044b\u0435 \u043a\u0430\u0440\u0442\u0438\u043d\u043a\u0438",validate:Object(de.d)(),multiple:!0,children:Object(r.jsx)(he,{source:"src"})})]})}))},he=function(e){var t=e.record,a=e.source;return"string"==typeof t&&(t=Object(je.a)({},a,t)),Object(r.jsx)(pe.a,{record:t,source:a})},ge=a(599),ve=function(e){return Object(r.jsx)(ge.a,Object(o.a)(Object(o.a)({},e),{},{children:Object(r.jsxs)(be.a,{children:[Object(r.jsx)(le.a,{label:"\u041d\u0430\u0437\u0432\u0430\u043d\u0438\u0435",source:"name",validate:Object(de.d)()}),Object(r.jsx)(le.a,{label:"\u041e\u043f\u0438\u0441\u0430\u043d\u0438\u0435",source:"description",validate:Object(de.d)()}),Object(r.jsx)(le.a,{label:"\u0426\u0435\u043d\u0430",source:"cost",validate:[Object(de.d)(),Object(de.c)(1),Object(de.b)(3e6)]}),Object(r.jsx)(le.a,{label:"\u041a\u043e\u043b\u0438\u0447\u0435\u0441\u0442\u0432\u043e",source:"count",validate:[Object(de.d)(),Object(de.c)(1),Object(de.b)(100)]}),Object(r.jsx)(le.a,{label:"\u0420\u0435\u0439\u0442\u0438\u043d\u0433",source:"rating",validate:[Object(de.d)(),Object(de.c)(0),Object(de.b)(10)]}),Object(r.jsx)(Oe.a,{label:"\u0422\u0438\u043f \u0433\u0438\u0442\u0430\u0440\u044b",source:"guitarTypeId",reference:"guitartypes",validate:Object(de.d)(),children:Object(r.jsx)(me.a,{optionText:"name"})}),Object(r.jsx)(xe.a,{source:"image",label:"\u041a\u0430\u0440\u0442\u0438\u043d\u043a\u0430",multiple:!1,children:Object(r.jsx)(we,{source:"src"})}),Object(r.jsx)(xe.a,{source:"files",label:"\u0414\u0435\u0442\u0430\u043b\u044c\u043d\u044b\u0435 \u043a\u0430\u0440\u0442\u0438\u043d\u043a\u0438",validate:Object(de.d)(),multiple:!0,children:Object(r.jsx)(we,{source:"src"})})]})}))},we=function(e){var t=e.record,a=e.source;return"string"==typeof t&&(t=Object(je.a)({},a,t)),Object(r.jsx)(pe.a,{record:t,source:a})},ye=function(e){return Object(r.jsx)(Y.a,Object(o.a)(Object(o.a)({},e),{},{title:"\u0421\u043f\u0438\u0441\u043e\u043a \u0442\u0438\u043f\u043e\u0432 \u0433\u0438\u0442\u0430\u0440",children:Object(r.jsxs)(Z.a,{rowClick:"edit",isRowSelectable:function(){return!1},children:[Object(r.jsx)($.a,{label:"\u041d\u0430\u0437\u0432\u0430\u043d\u0438\u0435",source:"name"}),Object(r.jsx)(ne.a,{render:function(e){return Object(r.jsx)("img",{src:e.img})}})]})}))},Ie=function(e){return Object(r.jsx)(ge.a,Object(o.a)(Object(o.a)({},e),{},{children:Object(r.jsx)(be.a,{children:Object(r.jsx)(le.a,{validate:Object(de.d)(),label:"\u041d\u0430\u0437\u0432\u0430\u043d\u0438\u0435",source:"name"})})}))},Se=function(e){return Object(r.jsx)(ue.a,Object(o.a)(Object(o.a)({},e),{},{children:Object(r.jsx)(be.a,{children:Object(r.jsx)(le.a,{validate:Object(de.d)(),label:"\u041d\u0430\u0437\u0432\u0430\u043d\u0438\u0435",source:"name"})})}))},Ce=function(e){return Object(r.jsx)(Y.a,Object(o.a)(Object(o.a)({},e),{},{sort:{field:"orderDate",order:"DESC"},children:Object(r.jsxs)(Z.a,{children:[Object(r.jsx)(ie.a,{label:"\u041f\u043e\u043b\u044c\u0437\u043e\u0432\u0430\u0442\u0435\u043b\u044c",source:"userId",reference:"users",children:Object(r.jsx)($.a,{source:"userName"})}),Object(r.jsx)(ee.a,{label:"\u0414\u0430\u0442\u0430 \u043f\u043e\u043a\u0443\u043f\u043a\u0438",source:"orderDate"}),Object(r.jsx)(ne.a,{label:"\u0426\u0435\u043d\u0430",render:function(e){return e.cartItems.reduce((function(e,t){return e+t.count*t.guitar.cost}))+" \u0440\u0443\u0431."}})]})}))},Te=a(25),ke=a(590),Pe=function(e){return Object(r.jsx)(ae.a,Object(o.a)(Object(o.a)({},e),{},{children:Object(r.jsxs)(re.a,{children:[Object(r.jsx)(ie.a,{label:"\u041f\u043e\u043b\u044c\u0437\u043e\u0432\u0430\u0442\u0435\u043b\u044c",source:"userId",reference:"users",children:Object(r.jsx)($.a,{source:"userName"})}),Object(r.jsx)(ee.a,{label:"\u0414\u0430\u0442\u0430 \u043f\u043e\u043a\u0443\u043f\u043a\u0438",source:"orderDate"}),Object(r.jsx)(ne.a,{label:"\u0426\u0435\u043d\u0430",render:function(e){return e.cartItems.reduce((function(e,t){return e+t.count*t.guitar.cost}))+" \u0440\u0443\u0431."}}),Object(r.jsx)(ke.a,{source:"cartItems",label:"\u041a\u043e\u0440\u0437\u0438\u043d\u0430",children:Object(r.jsxs)(Z.a,{children:[Object(r.jsx)($.a,{source:"guitarCount",label:"\u041a\u043e\u043b\u0438\u0447\u0435\u0441\u0442\u0432\u043e \u0433\u0438\u0442\u0430\u0440"}),Object(r.jsx)(ne.a,{label:"\u041d\u0430\u0437\u0432\u0430\u043d\u0438\u0435",render:function(e){return e.guitar.name}}),Object(r.jsx)(ne.a,{label:"\u0426\u0435\u043d\u0430",render:function(e){return e.guitar.cost+" \u0440\u0443\u0431."}}),Object(r.jsx)(ne.a,{label:"\u041f\u0440\u043e\u0441\u043c\u043e\u0442\u0440",render:function(e){return Object(r.jsx)(Te.a,{to:"/guitars/"+e.guitar.id+"/show",children:"\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c"})}})]})})]})}))},Fe=a(8),De=a(519),Ne=a(597),Re=a(135),Ee=a.n(Re),Ae=a(176),Je=function(e){var t=e.onMenuClick,a=e.logout,n=e.dense,s=void 0!==n&&n,i=Object(c.useState)({diseas:!0}),o=Object(k.a)(i,2),j=(o[0],o[1],Object(De.a)((function(e){return e.breakpoints.down("xs")}))),u=Object(Fe.f)((function(e){return e.admin.ui.sidebarOpen}));Object(Fe.f)((function(e){return e.theme}));var b=localStorage.getItem("permissions"),l=b&&JSON.parse(b);null===l||void 0===l||l.includes("Admin");return Object(r.jsxs)(Ne.a,{mt:1,children:[Object(r.jsx)(Ae.a,{to:"/users",primaryText:"\u041f\u043e\u043b\u044c\u0437\u043e\u0432\u0430\u0442\u0435\u043b\u0438",onClick:t,sidebarIsOpen:u,dense:s,leftIcon:Object(r.jsx)(Ee.a,{})}),Object(r.jsx)(Ae.a,{to:"/guitars",primaryText:"\u0413\u0438\u0442\u0430\u0440\u044b",onClick:t,sidebarIsOpen:u,dense:s,leftIcon:Object(r.jsx)(Ee.a,{})}),Object(r.jsx)(Ae.a,{to:"/guitartypes",primaryText:"\u0422\u0438\u043f\u044b \u0433\u0438\u0442\u0430\u0440",onClick:t,sidebarIsOpen:u,dense:s,leftIcon:Object(r.jsx)(Ee.a,{})}),Object(r.jsx)(Ae.a,{to:"/orders",primaryText:"\u0417\u0430\u043a\u0430\u0437\u044b",onClick:t,sidebarIsOpen:u,dense:s,leftIcon:Object(r.jsx)(Ee.a,{})}),j&&a]})},_e=(a(573),a(92),a(604),a(607),a(608),a(487)),Be=Object(O.a)((function(){return _e}),"ru"),Le=function(e){return Object(r.jsx)(j.a,Object(o.a)(Object(o.a)({},e),{},{children:Object(r.jsx)(n.a.Fragment,{children:Object(r.jsx)(K,Object(o.a)({},e))})}))};function qe(){return Object(r.jsxs)(u.a,{theme:X,dataProvider:w,i18nProvider:Be,authProvider:y,loginPage:Le,menu:Je,children:[Object(r.jsx)(b.a,{name:"users",list:te,show:ce,icon:d.a,options:{label:"\u041f\u043e\u043b\u044c\u0437\u043e\u0432\u0430\u0442\u0435\u043b\u0438"}}),Object(r.jsx)(b.a,{name:"guitars",list:se,show:oe,create:fe,edit:ve,icon:d.a,options:{label:"\u0413\u0438\u0442\u0430\u0440\u044b"}}),Object(r.jsx)(b.a,{name:"guitartypes",list:ye,edit:Ie,create:Se,icon:d.a,options:{label:"\u0422\u0438\u043f\u044b \u0433\u0438\u0442\u0430\u0440"}}),Object(r.jsx)(b.a,{name:"orders",list:Ce,show:Pe,icon:d.a,options:{label:"\u0417\u0430\u043a\u0430\u0437\u044b"}})]})}var ze=function(e){e&&e instanceof Function&&a.e(3).then(a.bind(null,614)).then((function(t){var a=t.getCLS,r=t.getFID,c=t.getFCP,n=t.getLCP,s=t.getTTFB;a(e),r(e),c(e),n(e),s(e)}))};i.a.render(Object(r.jsx)(qe,{}),document.getElementById("root")),ze()}},[[507,1,2]]]);
//# sourceMappingURL=main.21f94803.chunk.js.map