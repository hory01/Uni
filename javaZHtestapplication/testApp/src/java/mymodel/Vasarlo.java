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
public class Vasarlo {
    
    String uname;
    String pw;
    ArrayList<Alkatresz> kosar;
    
    public String getUname(){
        return uname;
    }
    
    public String getPw(){
        return pw;
    }
    
    public ArrayList<Alkatresz> getKosar(){
        return kosar;
    }
    
    public void addKosarhoz(Alkatresz item){
        kosar.add(item);
    }
    
    public void setUname(String uname){
        this.uname = uname;
    }
    
    public void setPw(String pw){
        this.pw = pw;
    }
    
    public void kosarbolTorol(Alkatresz a){
        kosar.remove(a);
    }
    
    public void kosarbolTorolElemet(String nev){
        for (int i = 0; i < kosar.size(); i++) {
            if (kosar.get(i).nev.equals(nev)) {
                kosar.remove(i);
            }
        }
    }
    
    public Vasarlo(String uname, String pw){
        this.uname = uname;
        this.pw = pw;
        kosar = new ArrayList<>();
    }
}
