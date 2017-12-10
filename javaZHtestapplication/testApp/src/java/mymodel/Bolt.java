/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package mymodel;

import java.util.ArrayList;

/**
 *
 * @author hory0
 */
public class Bolt {
    
    ArrayList<Vasarlo> vevok;
    ArrayList<Alkatresz> lista;
    public Bolt(){
        
        
        Vasarlo test = new Vasarlo("test", "alma");
        test.kosar.add(new Alkatresz("turbo"));
        test.kosar.add(new Alkatresz("olaj"));
        test.kosar.add(new Alkatresz("kendő"));
        vevok = new ArrayList<>();
        lista = new ArrayList<>();
        vevok.add(test);
        lista.add(new Alkatresz("turbo"));
        lista.add(new Alkatresz("felni"));
        lista.add(new Alkatresz("olaj"));
    }
    
    public ArrayList<Vasarlo> getVevok(){
        return vevok;
    }
    
    public void addLista(String item){
        lista.add(new Alkatresz(item));
    }
    
    public ArrayList<Alkatresz> getLista(){
            return lista;
        }
        
        public void Regisztral(String uname, String pw){
            vevok.add(new Vasarlo(uname, pw));
        }
            
}
