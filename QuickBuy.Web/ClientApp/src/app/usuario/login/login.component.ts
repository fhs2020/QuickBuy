import { Component } from "@angular/core";
import { Ususario } from "../../modelo/usuario";

@Component({
  selector: "app-login",
  templateUrl: "./login.component.html",
  styleUrls: ["./login.component.css"]

})

export class LoginComponent {

  public usuario = new Ususario();
  usuarioAutenticado: boolean;

  constructor() {
    this.usuario = new Ususario();
  }


  public enderecoImagem = "https://d23stzf11uxe1a.cloudfront.net/wp-content/uploads/2019/02/22100711/buying.jpg";
  public titulo = "seja bem vindo!";

  public email = "flavio.sousa@msn.com";

  entrar() {
    if (this.usuario.email == "flavio.sousa@cnn.com" && this.usuario.senha == "abc123")
      this.usuarioAutenticado = true;
  }

}
