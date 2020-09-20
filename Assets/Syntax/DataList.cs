using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using System;

namespace Vuforia
{
	public class DataList : MonoBehaviour {
//       string kunci = null;
//        public GameObject PanelHasil;
        public Text Judul;
        public Text Isi;
        //public Text textHasil;
        public GameObject Penjelasan;

        // string[] jawaban = new string[5];
        // System.Random randomDirection = new System.Random();
        // int x,y;

		void Start () {
            Judul.text = "";
            Isi.text = "";
            Penjelasan.SetActive(false);
		}

		void Update()
		{
            StateManager sm = TrackerManager.Instance.GetStateManager();
			IEnumerable<TrackableBehaviour> tbs = sm.GetActiveTrackableBehaviours();
            Judul.text = "";
            Isi.text = "";
            Penjelasan.SetActive(false);
                foreach (TrackableBehaviour tb in tbs)
                {
                    Penjelasan.SetActive(true);

                    Judul.text = tb.TrackableName;
//                    acakJawab();

                    //Plane.SetActive(false);

                    if (tb.TrackableName == "SIKLUS_AIR")
                    {
                        Isi.text = "Siklus Air adalah sirkulasi air yang tidak pernah berhenti dari atmosfer ke bumi dan kembali ke atmosfer melalui kondensasi, presipitasi, evaporasi dan transpirasi.";
                        Judul.text = "SIKLUS AIR";

                    }else if(tb.TrackableName == "EVAPORASI"){
                        Isi.text = "Evaporasi atau penguapan adalah proses dimana air yang ada di laut, rawa, danau, samudra dan lainnya menguap akibat adanya pemanasan sinar matahari. Dalam tahapan ini, air diubah menjadi uap air (gas) sehingga bisa naik ke atas atmosfer.";
                    }else if(tb.TrackableName == "TRANSPIRASI"){
                        Isi.text = "Transpirasi merupakan proses penguapan yang serupa dengan evaporasi. Hanya saja proses penguapan ini terjadi pada jaringan makhluk hidup. Transpirasi juga mengubah air menjadi uap air dan di bawa ke atmosfer.";
                    }else if(tb.TrackableName == "KONDENSASI" ){
                        Isi.text = "Kondensasi adalah proses berubahnya air menjadi partikel es akibat suhu udara yang rendah hingga akhirnya membentuk awan hitam yang tebal.";
                    }else if(tb.TrackableName == "PRESIPITASI" ){
                        Isi.text = "Presipitasi adalah proses pencairan awan hitam hingga jatuh menjadi hujan.";
                    }else if(tb.TrackableName == "INFILTRASI" ){
                        Isi.text = "Infiltrasi adalah proses terakhir dari siklus daur air yakni penyerapan air ke dalam tanah.";
                    }
                }

		}

        // public void SelectJawabanA(){
        //     string hasil;
        //     if(textJawabanA.text == kunci)
        //     {
        //         hasil = "Jawaban Anda Benar";
        //         textHasil.text = hasil;
        //         PanelHasil.SetActive(true);
        //     }
        //     else if(textJawabanA.text == "SIKLUS AIR")
        //     {
        //         hasil = "Jawaban Anda Benar";
        //         textHasil.text = hasil;
        //         PanelHasil.SetActive(true);
        //     }         
        //     else
        //     {
        //         hasil = "Jawaban Anda Salah";
        //         textHasil.text = hasil;
        //         PanelHasil.SetActive(true);
        //     }

            
        // }

        // public void SelectJawabanB(){
        //     string hasil;
        //     if(textJawabanB.text == kunci){
        //         hasil = "Jawaban Anda Benar";
        //         textHasil.text = hasil;
        //         PanelHasil.SetActive(true);
        //     }else{
        //         hasil = "Jawaban Anda Salah";
        //         textHasil.text = hasil;
        //         PanelHasil.SetActive(true);
        //     }
        // }

//         public void closeHasil(){
//             PanelHasil.SetActive(false);
//             x = randomDirection.Next(0, 4);
//             y = randomDirection.Next(0, 4);
//             Judul.SetActive(false);
//             Isi.SetActive(false);
//  //           Penjelasan.SetActive(false);
//         }


        // void acakJawab(){
        //     textJawabanA.text = jawaban[x];
            
        //     if (textJawabanA.text == kunci){                
        //         textJawabanB.text = jawaban[y];
        //         if (textJawabanB.text == kunci){
        //             y = randomDirection.Next(0, 4);               
        //             textJawabanB.text = jawaban[y];
        //         }
        //     }else{
        //         textJawabanB.text = kunci;
        //     }
        // }
        
	}
}
