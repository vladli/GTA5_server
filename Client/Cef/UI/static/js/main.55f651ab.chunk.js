(this.webpackJsonpui=this.webpackJsonpui||[]).push([[0],{119:function(e,a,r){},126:function(e,a,r){},127:function(e,a,r){"use strict";r.r(a);var t=r(3),n=r(0),i=r.n(n),c=r(12),d=r.n(c),o=(r(119),r(38)),s=r(90),l=r(30),p=r(158),h=r(161),g=r(163),x=r(164),A=r(165),j=r(129),b=r(168),m=r(166),O=r(169),u={events:{},addHandler:function(e,a){e in this.events?this.events[e].push(a):this.events[e]=[a]},removeHandler:function(e,a){if(e in this.events){var r=this.events[e].indexOf(a);this.events[e].splice(r,1)}}};var f=r(9),C=r(8),v=r(2),B=r(58),w=r.n(B),H=function(e){e=(e+="").replace("#","");if(!/[0-9A-Fa-f]/g.test(e)||3!==e.length&&6!==e.length)throw new Error("input is not a valid hex color.");if(3===e.length){var a=e[0],r=e[1],t=e[2];e=a+a+r+r+t+t}var n=(e=e.toUpperCase())[0]+e[1],i=e[2]+e[3],c=e[4]+e[5];return parseInt(n,16)+", "+parseInt(i,16)+", "+parseInt(c,16)},I=["#9c27b0","#ab47bc","#8e24aa","#af2cc5"],k=["#ff9800","#ffa726","#fb8c00","#ffa21a"],E=["#f44336","#ef5350","#e53935","#f55a4e"],T=["#4caf50","#66bb6a","#43a047","#5cb860"],D=["#00acc1","#26c6da","#00acc1","#00d3ee"],U=["#e91e63","#ec407a","#d81b60","#eb3573"],W=["#999","#777","#3C4858","#AAAAAA","#D2D2D2","#DDD","#b4b4b4","#555555","#333","#a9afbb","#eee","#e7e7e7"],M="#000",N="#FFF",R=(H(M),H(M),H(M),{boxShadow:"0 4px 20px 0 rgba("+H(M)+",.14), 0 7px 10px -5px rgba("+H(I[0])+",.4)"}),S={boxShadow:"0 4px 20px 0 rgba("+H(M)+",.14), 0 7px 10px -5px rgba("+H(D[0])+",.4)"},Q={boxShadow:"0 4px 20px 0 rgba("+H(M)+",.14), 0 7px 10px -5px rgba("+H(T[0])+",.4)"},q={boxShadow:"0 4px 20px 0 rgba("+H(M)+",.14), 0 7px 10px -5px rgba("+H(k[0])+",.4)"},V={boxShadow:"0 4px 20px 0 rgba("+H(M)+",.14), 0 7px 10px -5px rgba("+H(E[0])+",.4)"},J={boxShadow:"0 4px 20px 0 rgba("+H(M)+",.14), 0 7px 10px -5px rgba("+H(U[0])+",.4)"},F=Object(f.a)({background:"linear-gradient(60deg, "+k[1]+", "+k[2]+")"},q),X=Object(f.a)({background:"linear-gradient(60deg, "+T[1]+", "+T[2]+")"},Q),P=Object(f.a)({background:"linear-gradient(60deg, "+E[1]+", "+E[2]+")"},V),y=Object(f.a)({background:"linear-gradient(60deg, "+D[1]+", "+D[2]+")"},S),z=Object(f.a)({background:"linear-gradient(60deg, "+I[1]+", "+I[2]+")"},R),Y=Object(f.a)({background:"linear-gradient(60deg, "+U[1]+", "+U[2]+")"},J),G=(Object(f.a)({margin:"0 20px 10px",paddingTop:"10px",borderTop:"1px solid "+W[10],height:"auto"},{fontFamily:'"Roboto", "Helvetica", "Arial", sans-serif',fontWeight:"300",lineHeight:"1.5em"}),H(M),H(M),H(M),H(M),H(M),{color:W[2],textDecoration:"none",fontWeight:"300",marginTop:"30px",marginBottom:"25px",minHeight:"32px",fontFamily:"'Roboto', 'Helvetica', 'Arial', sans-serif","& small":{color:W[1],fontWeight:"400",lineHeight:"1"}}),Z=(Object(f.a)(Object(f.a)({},G),{},{marginTop:"0",marginBottom:"3px",minHeight:"auto","& a":Object(f.a)(Object(f.a)({},G),{},{marginTop:".625rem",marginBottom:"0.75rem",minHeight:"auto"})}),Object(p.a)({card:{border:"0",marginBottom:"30px",marginTop:"30px",borderRadius:"6px",color:"rgba("+H(M)+", 0.87)",background:"#333",width:"100%",boxShadow:"0 1px 4px 0 rgba("+H(M)+", 0.14)",position:"relative",display:"flex",flexDirection:"column",minWidth:"0",wordWrap:"break-word",fontSize:".875rem"},cardPlain:{background:"transparent",boxShadow:"none"},cardProfile:{marginTop:"30px",textAlign:"center"},cardChart:{"& p":{marginTop:"0px",paddingTop:"0px"}}}));function K(e){var a,r=Z(),n=e.className,i=e.children,c=e.plain,d=e.profile,o=e.chart,s=Object(v.a)(e,["className","children","plain","profile","chart"]),l=w()((a={},Object(C.a)(a,r.card,!0),Object(C.a)(a,r.cardPlain,c),Object(C.a)(a,r.cardProfile,d),Object(C.a)(a,r.cardChart,o),Object(C.a)(a,n,void 0!==n),a));return Object(t.jsx)("div",Object(f.a)(Object(f.a)({className:l},s),{},{children:i}))}var L=Object(p.a)({cardBody:{padding:"0.9375rem 20px",flex:"1 1 auto",WebkitBoxFlex:"1",position:"relative"},cardBodyPlain:{paddingLeft:"5px",paddingRight:"5px"},cardBodyProfile:{marginTop:"15px"}});function $(e){var a,r=L(),n=e.className,i=e.children,c=e.plain,d=e.profile,o=Object(v.a)(e,["className","children","plain","profile"]),s=w()((a={},Object(C.a)(a,r.cardBody,!0),Object(C.a)(a,r.cardBodyPlain,c),Object(C.a)(a,r.cardBodyProfile,d),Object(C.a)(a,n,void 0!==n),a));return Object(t.jsx)("div",Object(f.a)(Object(f.a)({className:s},o),{},{children:i}))}var _=Object(p.a)({cardHeader:{padding:"0.75rem 1.25rem",marginBottom:"0",borderBottom:"none",background:"transparent",zIndex:"3 !important","&$cardHeaderPlain,&$cardHeaderIcon,&$cardHeaderStats,&$warningCardHeader,&$successCardHeader,&$dangerCardHeader,&$infoCardHeader,&$primaryCardHeader,&$roseCardHeader":{margin:"0 15px",padding:"0",position:"relative",color:N},"&:first-child":{borderRadius:"calc(.25rem - 1px) calc(.25rem - 1px) 0 0"},"&$warningCardHeader,&$successCardHeader,&$dangerCardHeader,&$infoCardHeader,&$primaryCardHeader,&$roseCardHeader":{"&:not($cardHeaderIcon)":{borderRadius:"3px",marginTop:"-20px",padding:"15px"}},"&$cardHeaderStats svg":{fontSize:"36px",lineHeight:"56px",textAlign:"center",width:"36px",height:"36px",margin:"10px 10px 4px"},"&$cardHeaderStats i,&$cardHeaderStats .material-icons":{fontSize:"36px",lineHeight:"56px",width:"56px",height:"56px",textAlign:"center",overflow:"unset",marginBottom:"1px"},"&$cardHeaderStats$cardHeaderIcon":{textAlign:"right"}},cardHeaderPlain:{marginLeft:"0px !important",marginRight:"0px !important"},cardHeaderStats:{"& $cardHeaderIcon":{textAlign:"right"},"& h1,& h2,& h3,& h4,& h5,& h6":{margin:"0 !important"}},cardHeaderIcon:{"&$warningCardHeader,&$successCardHeader,&$dangerCardHeader,&$infoCardHeader,&$primaryCardHeader,&$roseCardHeader":{background:"transparent",boxShadow:"none"},"& i,& .material-icons":{width:"33px",height:"33px",textAlign:"center",lineHeight:"33px"},"& svg":{width:"24px",height:"24px",textAlign:"center",lineHeight:"33px",margin:"5px 4px 0px"}},warningCardHeader:{color:N,"&:not($cardHeaderIcon)":Object(f.a)({},F)},successCardHeader:{color:N,"&:not($cardHeaderIcon)":Object(f.a)({},X)},dangerCardHeader:{color:N,"&:not($cardHeaderIcon)":Object(f.a)({},P)},infoCardHeader:{color:N,"&:not($cardHeaderIcon)":Object(f.a)({},y)},primaryCardHeader:{color:N,"&:not($cardHeaderIcon)":Object(f.a)({},z)},roseCardHeader:{color:N,"&:not($cardHeaderIcon)":Object(f.a)({},Y)}});function ee(e){var a,r=_(),n=e.className,i=e.children,c=e.color,d=e.plain,o=e.stats,s=e.icon,l=Object(v.a)(e,["className","children","color","plain","stats","icon"]),p=w()((a={},Object(C.a)(a,r.cardHeader,!0),Object(C.a)(a,r[c+"CardHeader"],c),Object(C.a)(a,r.cardHeaderPlain,d),Object(C.a)(a,r.cardHeaderStats,o),Object(C.a)(a,r.cardHeaderIcon,s),Object(C.a)(a,n,void 0!==n),a));return Object(t.jsx)("div",Object(f.a)(Object(f.a)({className:p},l),{},{children:i}))}var ae=r(104),re=r.n(ae),te=r(103),ne=r.n(te),ie=r(107),ce=r.n(ie),de=r(106),oe=r.n(de),se=r(89),le=r.n(se),pe=r(86),he=r.n(pe),ge=r(105),xe=r.n(ge),Ae=Object(p.a)({paper:{marginTop:"20vh",marginBottom:"20vh",margin:"auto",paddingLeft:"auto",maxWidth:"100vh"},grid:{marginLeft:"10px",marginRight:"10px",justify:"center",alignItems:"center",alignContent:"center"},card:{marginTop:"5em",marginBottom:"2em"}});function je(e){alert(e)}function be(){var e=Ae();return Object(n.useEffect)((function(){u.addHandler("ASD",je)})),Object(t.jsx)("div",{children:Object(t.jsx)(h.a,{className:e.paper,children:Object(t.jsxs)(g.a,{container:!0,justify:"center",alignItems:"center",style:{minHeight:"60vh"},children:[Object(t.jsx)(g.a,{item:!0,xs:!0,className:e.grid,children:Object(t.jsx)(K,{children:Object(t.jsx)(x.a,{component:"img",image:"data:image/png;base64,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"})})}),Object(t.jsx)(A.a,{orientation:"vertical",flexItem:!0}),Object(t.jsx)(g.a,{item:!0,xs:!0,className:e.grid,children:Object(t.jsx)(me,{})})]})})})}var me=function(){var e=Ae(),a=i.a.useState(!0),r=Object(o.a)(a,2),c=r[0],d=r[1];Object(n.useEffect)((function(){u.addHandler("ASD",je)}));var p=Object(s.a)({initialValues:{name:"",password:""},validationSchema:l.a({name:l.c().required("\u042d\u0442\u043e \u043f\u043e\u043b\u0435 \u043e\u0431\u044f\u0437\u0430\u0442\u0435\u043b\u044c\u043d\u043e \u043a \u0437\u0430\u043f\u043e\u043b\u043d\u0435\u043d\u0438\u044e."),password:l.c().required("\u042d\u0442\u043e \u043f\u043e\u043b\u0435 \u043e\u0431\u044f\u0437\u0430\u0442\u0435\u043b\u044c\u043d\u043e \u043a \u0437\u0430\u043f\u043e\u043b\u043d\u0435\u043d\u0438\u044e.")}),onSubmit:function(e){alert(JSON.stringify(e))}}),h=Object(s.a)({initialValues:{name:"",email:"",password_1:"",password_2:""},validationSchema:l.a({name:l.c().required("\u042d\u0442\u043e \u043f\u043e\u043b\u0435 \u043e\u0431\u044f\u0437\u0430\u0442\u0435\u043b\u044c\u043d\u043e \u043a \u0437\u0430\u043f\u043e\u043b\u043d\u0435\u043d\u0438\u044e.").min(4,"\u041c\u0438\u043d\u0438\u043c\u0430\u043b\u044c\u043d\u043e\u0435 \u043a\u043e\u043b-\u0432\u043e \u0441\u0438\u043c\u0432\u043e\u043b\u043e\u0432 - 4.").max(16,"\u041c\u0430\u043a\u0441\u0438\u043c\u0430\u043b\u044c\u043d\u043e\u0435 \u043a\u043e\u043b-\u0432\u043e \u0441\u0438\u043c\u0432\u043e\u043b\u043e\u0432 - 16.").matches(/^[a-zA-Z]+$/,"\u041f\u043e\u043b\u0435 \u043c\u043e\u0436\u0435\u0442 \u0441\u043e\u0441\u0442\u043e\u044f\u0442\u044c \u0442\u043e\u043b\u044c\u043a\u043e \u0438\u0437 \u0431\u0443\u043a\u0432 \u043b\u0430\u0442\u0438\u043d\u0441\u043a\u043e\u0433\u043e \u0430\u043b\u0444\u0430\u0432\u0438\u0442\u0430."),email:l.c().email(),password_1:l.c().required("\u042d\u0442\u043e \u043f\u043e\u043b\u0435 \u043e\u0431\u044f\u0437\u0430\u0442\u0435\u043b\u044c\u043d\u043e \u043a \u0437\u0430\u043f\u043e\u043b\u043d\u0435\u043d\u0438\u044e.").min(6,"\u041c\u0438\u043d\u0438\u043c\u0430\u043b\u044c\u043d\u043e\u0435 \u043a\u043e\u043b-\u0432\u043e \u0441\u0438\u043c\u0432\u043e\u043b\u043e\u0432 - 6.").max(16,"\u041c\u0430\u043a\u0441\u0438\u043c\u0430\u043b\u044c\u043d\u043e\u0435 \u043a\u043e\u043b-\u0432\u043e \u0441\u0438\u043c\u0432\u043e\u043b\u043e\u0432 - 16."),password_2:l.c().required("\u042d\u0442\u043e \u043f\u043e\u043b\u0435 \u043e\u0431\u044f\u0437\u0430\u0442\u0435\u043b\u044c\u043d\u043e \u043a \u0437\u0430\u043f\u043e\u043b\u043d\u0435\u043d\u0438\u044e.").oneOf([l.b("password_1"),""],"\u041f\u0430\u0440\u043e\u043b\u044c \u043d\u0435 \u0441\u043e\u0432\u043f\u0430\u0434\u0430\u0435\u0442.")}),onSubmit:function(e){alert(JSON.stringify(e))}});return c?Object(t.jsx)("form",{onSubmit:p.handleSubmit,children:Object(t.jsx)(g.a,{container:!0,direction:"column",alignItems:"center",justify:"center",children:Object(t.jsxs)(K,{children:[Object(t.jsx)(ee,{color:"danger",children:Object(t.jsx)(j.a,{variant:"h5",color:"initial",children:"\u0410\u0432\u0442\u043e\u0440\u0438\u0437\u0430\u0446\u0438\u044f"})}),Object(t.jsxs)($,{children:[Object(t.jsx)(b.a,{name:"name",label:"\u041b\u043e\u0433\u0438\u043d",variant:"outlined",fullWidth:!0,style:{marginBottom:"2em"},onChange:p.handleChange,value:p.values.name,error:!!p.errors.name,helperText:p.errors.name,InputProps:{endAdornment:Object(t.jsx)(m.a,{position:"end",children:Object(t.jsx)(le.a,{})})}}),Object(t.jsx)(b.a,{name:"password",label:"\u041f\u0430\u0440\u043e\u043b\u044c",variant:"outlined",fullWidth:!0,style:{marginBottom:"2em"},onChange:p.handleChange,value:p.values.password,error:!!p.errors.password,helperText:p.errors.password,InputProps:{endAdornment:Object(t.jsx)(m.a,{position:"end",children:Object(t.jsx)(he.a,{})})}}),Object(t.jsxs)(g.a,{container:!0,direction:"row",justify:"flex-end",spacing:1,children:[Object(t.jsx)(g.a,{item:!0,children:Object(t.jsxs)(O.a,{size:"medium",variant:"contained",color:"primary",type:"submit",children:[Object(t.jsx)(ne.a,{}),"\u0412\u0445\u043e\u0434"]})}),Object(t.jsx)(g.a,{item:!0,children:Object(t.jsxs)(O.a,{size:"medium",variant:"contained",color:"secondary",onClick:function(){return d((function(e){return!e}))},children:[Object(t.jsx)(re.a,{}),"\u0420\u0435\u0433\u0438\u0441\u0442\u0440\u0430\u0446\u0438\u044f"]})})]})]})]})})}):Object(t.jsx)("form",{onSubmit:h.handleSubmit,children:Object(t.jsx)(g.a,{container:!0,direction:"column",alignItems:"center",justify:"center",children:Object(t.jsxs)(K,{className:e.card,children:[Object(t.jsx)(ee,{color:"danger",children:Object(t.jsx)(j.a,{variant:"h5",color:"initial",children:"\u0420\u0435\u0433\u0438\u0441\u0442\u0440\u0430\u0446\u0438\u044f"})}),Object(t.jsxs)($,{children:[Object(t.jsx)(b.a,{name:"name",label:"\u041b\u043e\u0433\u0438\u043d",variant:"outlined",fullWidth:!0,style:{marginBottom:"2em"},onChange:h.handleChange,value:h.values.name,error:!!h.errors.name,helperText:h.errors.name,InputProps:{endAdornment:Object(t.jsx)(m.a,{position:"end",children:Object(t.jsx)(le.a,{})})}}),Object(t.jsx)(b.a,{name:"email",label:"Email",variant:"outlined",fullWidth:!0,style:{marginBottom:"2em"},onChange:h.handleChange,value:h.values.email,error:!!h.errors.email,helperText:h.errors.email,InputProps:{endAdornment:Object(t.jsx)(m.a,{position:"end",children:Object(t.jsx)(xe.a,{})})}}),Object(t.jsx)(b.a,{name:"password_1",label:"\u041f\u0430\u0440\u043e\u043b\u044c",variant:"outlined",fullWidth:!0,style:{marginBottom:"2em"},onChange:h.handleChange,value:h.values.password_1,error:!!h.errors.password_1,helperText:h.errors.password_1,InputProps:{endAdornment:Object(t.jsx)(m.a,{position:"end",children:Object(t.jsx)(he.a,{})})}}),Object(t.jsx)(b.a,{name:"password_2",label:"\u041f\u043e\u0434\u0442\u0432\u0435\u0440\u0434\u0438\u0442\u0435 \u043f\u0430\u0440\u043e\u043b\u044c",variant:"outlined",fullWidth:!0,style:{marginBottom:"2em"},onChange:h.handleChange,value:h.values.password_2,error:!!h.errors.password_2,helperText:h.errors.password_2,InputProps:{endAdornment:Object(t.jsx)(m.a,{position:"end",children:Object(t.jsx)(he.a,{})})}}),Object(t.jsxs)(g.a,{container:!0,direction:"row",justify:"flex-end",spacing:1,children:[Object(t.jsx)(g.a,{item:!0,children:Object(t.jsxs)(O.a,{size:"medium",variant:"contained",color:"primary",type:"submit",children:[Object(t.jsx)(oe.a,{}),"\u0414\u0430\u043b\u0435\u0435"]})}),Object(t.jsx)(g.a,{item:!0,children:Object(t.jsxs)(O.a,{size:"medium",variant:"contained",color:"secondary",onClick:function(){return d((function(e){return!e}))},children:[Object(t.jsx)(ce.a,{}),"\u041d\u0430\u0437\u0430\u0434"]})})]})]})]})})})};r(126);var Oe=function(){return Object(t.jsx)("div",{className:"App",children:Object(t.jsx)(be,{})})},ue=function(e){e&&e instanceof Function&&r.e(3).then(r.bind(null,170)).then((function(a){var r=a.getCLS,t=a.getFID,n=a.getFCP,i=a.getLCP,c=a.getTTFB;r(e),t(e),n(e),i(e),c(e)}))},fe=r(108),Ce=r(167),ve=Object(fe.a)({palette:{type:"dark",primary:{main:"#1976d2"}}});d.a.render(Object(t.jsx)(i.a.StrictMode,{children:Object(t.jsx)(Ce.a,{theme:ve,children:Object(t.jsx)(Oe,{})})}),document.getElementById("root")),ue()}},[[127,1,2]]]);
//# sourceMappingURL=main.55f651ab.chunk.js.map