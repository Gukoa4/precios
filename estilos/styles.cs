body {
  font-family: "Ubuntu", sans-serif;
  -webkit-user-select: none;
    -moz-user-select: none;
    -ms-user-select: none;
    user-select: none;
}

.nav-bar {
  background: #a95682;
  color: #fff;
  height: 2rem;
  margin: 0;
  padding: 0;
}
.nav-bar a {
  margin: 0;
  font-size: 1.4rem;
  font-weight: bolder;
  
}
a {
  outline: none;
  text-decoration: none;
  padding: 0 1rem;
}
a:visited {
  color: #ffffff;
}
.actual{
  color: black;
}

a:link {
  color: #f7f7f7;
}


a:focus {
  background: #8f496e;
}

a:hover {
  background: #773c5c;
}

a:active {
  background: #773c5c;
  color: #914d72;
}
.content {
  background-color: #ddd;
  width: 1100px;
  margin: auto;
}

.selectores {
  display: flex;
  flex-wrap: wrap;
  height: 2rem;
  /* justify-content: space-evenly; */
  align-content: center;
  padding: 1rem;
}
.selectores div{
  padding: 1rem;
}

.container-precios {
  padding: 1rem;
  height: 550px;
  background-color: rgb(240, 240, 240);
  display: grid;
  grid-template-columns: 1fr 1fr 2fr;
  grid-gap: 1rem;
  grid-auto-rows: minmax(100px, auto);
  font-size: 22px;
}
.container-cable {
  height: 400px;

}
.container-internet {
height: 400px;

}
.container-totales {
  /* height: 400px; */
}
.recuadro {
  border-radius: 5px;
  display: flex;
  padding: auto;
  margin: 1rem 0;
  background-color: #c4c4c4;
  height: 3rem;
  position: relative;
}
.recuadro:hover{
  background-color: #b1b1b1;
}
.item {
  display: flex;
  width: 100%;
  align-self: center;
  justify-content: center;
  padding: 1em;
}
.start{
  justify-content: flex-start;

}
.stepper {
  display: flex;
  align-self: center;
  align-items: center;
  justify-content: center;
  /* margin: 1rem; */
  font-size: 1.1rem;
  background-color: #fff;
  border-radius: 10px;
  border: 2px #555 solid;
  color: #555;
  width: 80px;
  position: absolute;
  right: 0.4rem;
  height: 1.6rem;
}
.porcentaje-data{
  /* background-color: #ff19004d; */
}

.material-icons {
  font-size: 18px !important;
  /* background-color: #15ff004d; */
  cursor: pointer;
  padding: 0.5rem 0.5rem;
  /* height: 1.8rem; */
  border-radius: 10px;
}
.cabecera {
  color: #fff;
  font-size: 2rem;
  border-radius: 5px;
  display: flex;
  padding: auto;
  margin: 1rem 0;
  background-color: #c4c4c4;
  height: 3rem;
  position: relative;
  align-items: center;
  justify-content: center;
}

.cable {
  background: #5ccfe9;
}
.internet {
  background: #f47474;
}
.total {
  background: #772953;
}

.resumen {
  padding: 0 1rem;
  border: 1px solid black;
  border-radius: 5px;
}
h4{margin: 0;}

table {
  font-size: medium;
  width: 100%;  
  border-collapse: collapse;
  overflow: hidden;
  margin-bottom: 1rem;
}
thead {
  text-transform: uppercase;
  background-color: #49a877;
  color: rgb(255, 255, 255);

}
tfoot {
  font-weight: bold;
  border: 1px solid black; 
}
td{
  text-align: center;
}
tr:nth-child(even){
  background-color: #dbffd4;
}

.active {
  background-color: #424f52;
  color: #fff;
}
.active:hover {
  background-color: #798b8f;
  color: #fff;
}

.material-icons:hover {
  color: #ff0088;
}
.material-icons:active {
  color: #15ff00;
}
