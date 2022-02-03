info=[
    {
        "date":"2018-02-10T12:00:00",
        "valeur":3
    },
    {
        "date":"2018-03-10T12:00:00",
        "valeur":3
    },
    {
        "date":"2018-03-10T12:10:00",
        "valeur":2
    },
    {
        "date":"2018-03-10T12:30:00",
        "valeur":4
    },
    {
        "date":"2018-03-10T12:40:00",
        "valeur":1
    },
    {
        "date":"2018-03-10T13:00:00",
        "valeur":3
    }
];

infoBis=[
    {
        "type":"Temperature",
        "nombreProbleme":7
    },
    {
        "type":"Son",
        "nombreProbleme":3
    },
    {
        "type":"Lumiere",
        "nombreProbleme":5
    }
];

infoObjectif=[
    {
        "type":"Temperature",
        "nombreProbleme":8
    },
    {
        "type":"Son",
        "nombreProbleme":6
    },
    {
        "type":"Lumiere",
        "nombreProbleme":4
    }
];

window.onload = function () {
    var points = [];
    var points2 = [];
    var points3 = [];
    
    var stockChart = new CanvasJS.StockChart("graph1",{//id de l'element html qui doit accueillir le graph
      title:{
        text:"test 1"
      },
      
      subtitles: [{
        text: "avec des données au pif"
      }],    
      charts: [{//le graph a proprement parlé
        axisY: [{//va affecter tous ce qui est sur l'axe vertical
            title:"genre les unitées"
        }],
        axisX: {//va affecter tous ce qui est sur l'axe horizontal
			labelFormatter: function (e) {//permet de formater les labels sur l'axe en question
				return CanvasJS.formatDate( e.value, "DD/MM/YYYY HH:mm");
			}}
            ,

        data: [
            {  
                type: "line",//le type de graphique
                dataPoints : points//la variable ou chercher les données (un tableau d'objet. les objets en question doivent avoir en attribut un x ou label et un y)
            }  
        ]
      }],
      rangeSelector:{//inputs alterant le navigator
          label:"interval",//pour renomer le range Selector
          buttons:[//por redéffinir les boutons du range Selector
              {
                label:"30min",
                range:30,
                rangeType:"minute"
              },
              {
                label:"10min",
                range:10,
                rangeType:"minute"
              },
              {
                label:"1H",
                range:1,
                rangeType:"hour"
              },
              {
                label:"tout",
                range:1,
                rangeType:"all"
              }
            ],
          inputFields:{

            valueFormatString:"DD/MM/YYYY HH:mm",//formatage des dates pour les afficher proprement dans les inputs

          }
      },
      navigator: {//partie basse permetant de se mouvoir dans le graph
        slider: {
          minimum: new Date(2018, 02, 10,12,20,0),//position de l'interval initial   /!\en js les mois commencent à 0
          maximum: new Date(2018, 02, 10,12,40,0)
        },
        axisX:{
            minimum:new Date(2018, 02, 10,11,55,0),//interval max du navigator
            maximum:new Date(2018, 02, 10,13,5,0)
        }
      }
    });
    
      
      for(var i = 0; i < info.length; i++){//remplissage des données apres coup (indispensable vu qu'on va etre asychrone)
        points.push({x: new Date(info[i].date), y: Number(info[i].valeur)});			
      }	
      stockChart.render();
      
      
      var chart = new CanvasJS.Chart("graph2", {
          title:{
              text: "diagramme baton du pif"              
            },
            axisY: [{
                labelFormatter: function (e) {//formatage plus simple
                    return e.value+" unite";
                },
                minimum:0//valeur min de l'axe vertical
            }
            ],
            data: [//pas compliqué de cumuler des graphs              
                {
                    type: "column",
                    showInLegend: true,
                    legendText: "resultats",
                    dataPoints: points2
                },
                {
                    type: "line",
                    showInLegend: true,
                    legendText: "objectifs",
                    dataPoints: points3
                }
            ]
        });
        
        for(var i = 0; i < infoBis.length; i++){
            points2.push({label:infoBis[i].type, y: Number(infoBis[i].nombreProbleme)});
            points3.push({label:infoObjectif[i].type, y: Number(infoObjectif[i].nombreProbleme)});			
        }	
	chart.render();

    
  }