/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package mymodel;

/**
 *
 * @author hory0
 */
public class Alkatresz {
    
    String nev;
    
    public String getAlkatreszNev(){
        return nev;
    }
    
    public void setAlkatreszNev(String nev){
        this.nev = nev;
    }
    
    public Alkatresz(String nev){
        this.nev = nev;
    }
    
    @Override
    public String toString(){
        return nev;
    }
            
            
}
