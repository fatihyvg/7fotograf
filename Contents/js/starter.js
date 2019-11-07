/**jquery başlangıç kısmı */
$(document).ready(function(){

$("#profilegallery").hoverGrid(); 
   /*modal aç*/ 
   $("#upload").click(function(){
          $("#upload-modal").show();
   });
   /*modal kapat */
   $('#closer').click(function(){
        $('#upload-modal').hide();
   });
   /*fotoğraf değişimi */
   $("input[name='file']").change(function(evt){
        var files = evt.target.files;
        var file = files[0];

        if(file) {
           var imgreader = new FileReader();
         imgreader.onload = function(e){
              document.getElementById('preview').src = e.target.result;
           }
            imgreader.readAsDataURL(file);
        } 
   });

   /*ana sayfa liste galerisi */
   $("#listgallery").justifiedGallery({
     rowHeight:250,
     opacity:'0.8',
     transition:'elastic',
     lastRow:'nojustify',
     captions:false
  });

  $("#categorygallery").justifiedGallery({
     rowHeight:250,
     opacity:'0.8',
     transition:'elastic',
     lastRow:'nojustify',
     captions:false                     
  });
  $("#homegallery").justifiedGallery({
     rowHeight:250,
     opacity:'0.8',
     transition:'elastic',
     lastRow:'nojustify',
     captions:false                    
  });                                                      
});
/**Tamamlanmasına göre hareket */
failed = function(xhr){
  var len = $("input[name='category']:checked").length;
  var max_count = 2;
  if(len > max_count){
       $(this).prop('checked','');
       alert('En Az 1 Kategori Seçiniz.');
  }
}
complete = function(xhr){
    alert('Başarılı Şekilde Eklendi.');
}

/**
 * checkbox chked kontrol
 */
function checkedcontrol(){
     var max_count = 2;
     var len = $("input[name='category']:checked").length;
     if(max_count == len) {
          $("input[name='category']").prop('checked',false);
          alert('En Az 1 Kategori Seçiniz.');
     }
}
