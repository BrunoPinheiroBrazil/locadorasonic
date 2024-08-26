namespace LocadoraSonic.Servicos
{
  public class ExemploClasseEstaticaENaoEstatica
  {
    public void UsandoClassesEstaticasENaoEstaticas()
    {
      //classe estatica 
      ClasseEstaticaSonic.OlaMundoSonic();

      //classe não estatica
      var clasSonic = new ClasseSonic();
      clasSonic.OlaMundoSonic();

      clasSonic.BoaNoiteMundo();

      var claseSonic2 = new ClasseSonic();
      claseSonic2.OlaMundoSonic();

      claseSonic2.OlaMundoSonic();
    }
  }
}
