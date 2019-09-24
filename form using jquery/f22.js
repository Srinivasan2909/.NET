var x=document.getElementById("form-div");


var y=document.createElement('form');
y.setAttribute("method","POST");
y.setAttribute("action","");
x.appendChild(y);

 var heading1=document.createElement('h1');
 heading1.innerHTML="Please fill up the form";
 x.appendChild(heading1);

 var label1=document.createElement('label')
 label1.setAttribute("value","name")
 label1.setAttribute("id","name1")
 label1.innerHTML="Name:"
 x.appendChild(label1)

 var input1=document.createElement('input')
 input1.setAttribute("type","text")
 input1.setAttribute("class","inp1")
 x.appendChild(input1)

 var br=document.createElement('br')
 x.appendChild(br)

 var hr=document.createElement('hr')
 x.appendChild(hr)

 var label2=document.createElement('label')
 label2.setAttribute("value","Password:")
 label2.setAttribute("id","name2")
 label2.innerHTML="Password:"
 x.appendChild(label2)

 var input2=document.createElement('input')
 input2.setAttribute("type","password")
 input2.setAttribute("class","inp2")
 x.appendChild(input2)

 var br=document.createElement('br')
 x.appendChild(br)

 var hr2=document.createElement('hr')
 x.appendChild(hr2)

 var label3=document.createElement('label')
 label3.setAttribute("value","Phone number:")
 label3.setAttribute("id","name3")
 label3.innerHTML="Phone number:"
 x.appendChild(label3)

 var input3=document.createElement('input')
 input3.setAttribute("type","number")
 input3.setAttribute("class","inp3")
 x.appendChild(input3)

 var hr3=document.createElement('hr')
 x.appendChild(hr3)




 var sub1=document.createElement('input')
 sub1.setAttribute("value","SUBMIT")
 sub1.setAttribute("type","button")
 x.appendChild(sub1)












 


