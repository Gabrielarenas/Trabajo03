//Clase principal
public class carne{
    //metodo principal
    public static void Main(String[] args){
        calculadora cerdo= new calculadora();
        calculadora res= new calculadora();
        //muestra en pantalla diga el numero 1
        Console.WriteLine("Diga la cantidad de libras de carne de cerdo");
        //lee un valor, lo convierte en entero y lo guarda en num1
        int num1=Convert.ToInt32(Console.ReadLine());
        //muestra en pantalla diga el numero 2
        Console.WriteLine("Diga la cantidad de libras de carne de res");
        //lee un valor, lo convierte en entero y lo guarda en num2
        int num2=Convert.ToInt32(Console.ReadLine());
        //defino una instancia de carne como vaca y la inicializo como nueva
         carne vaca=new carne();
        //llama al metodo sumar con los parametros num1 y num2
        cerdo.sumar(num1,num2);
        //llama al metodo multi con los parametros num2 y num1
        res.multi(num2,num1);
    }
    //clase calculadora que permite sumar y dividir
public class calculadora{
    //atributo para guardar el peso de la carne
    string peso;
    //metodo sumar que suma dos numeros
    public void sumar(int num1,int num2){
        /*muestra en pantalla la suma de dos numeros
        */
        Console.WriteLine("La suma es "+(num1+num2));
    }
    //metodo divi que divide a entre b
    public void multi(double num1,double num2){
        //muestra en pantalla la suma de nm1+num2 y la multiplica por el precio por libra
        Console.WriteLine("El precio total es "+(num1+num2)*10000);
    }
    
    }
}
   