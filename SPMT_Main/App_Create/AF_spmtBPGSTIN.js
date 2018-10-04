<script type="text/javascript"> 
var script_spmtBPGSTIN = {
    ACEBPID_Selected: function(sender, e) {
      var Prefix = sender._element.id.replace('BPID','');
      var F_BPID = $get(sender._element.id);
      var F_BPID_Display = $get(sender._element.id + '_Display');
      var retval = e.get_value();
      var p = retval.split('|');
      F_BPID.value = p[0];
      F_BPID_Display.innerHTML = e.get_text();
    },
    ACEBPID_Populating: function(sender,e) {
      var p = sender.get_element();
      var Prefix = sender._element.id.replace('BPID','');
      p.style.backgroundImage  = 'url(../../images/loader.gif)';
      p.style.backgroundRepeat= 'no-repeat';
      p.style.backgroundPosition = 'right';
      sender._contextKey = '';
    },
    ACEBPID_Populated: function(sender,e) {
      var p = sender.get_element();
      p.style.backgroundImage  = 'none';
    },
    validate_BPID: function(sender) {
      var Prefix = sender.id.replace('BPID','');
      this.validated_FK_VR_BPGSTIN_BPID_main = true;
      this.validate_FK_VR_BPGSTIN_BPID(sender,Prefix);
      },
    validate_FK_VR_BPGSTIN_BPID: function(o,Prefix) {
      var value = o.id;
      var BPID = $get(Prefix + 'BPID');
      if(BPID.value==''){
        if(this.validated_FK_VR_BPGSTIN_BPID_main){
          var o_d = $get(Prefix + 'BPID' + '_Display');
          try{o_d.innerHTML = '';}catch(ex){}
        }
        return true;
      }
      value = value + ',' + BPID.value ;
        o.style.backgroundImage  = 'url(../../images/pkloader.gif)';
        o.style.backgroundRepeat= 'no-repeat';
        o.style.backgroundPosition = 'right';
        PageMethods.validate_FK_VR_BPGSTIN_BPID(value, this.validated_FK_VR_BPGSTIN_BPID);
      },
    validated_FK_VR_BPGSTIN_BPID_main: false,
    validated_FK_VR_BPGSTIN_BPID: function(result) {
      var p = result.split('|');
      var o = $get(p[1]);
      if(script_spmtBPGSTIN.validated_FK_VR_BPGSTIN_BPID_main){
        var o_d = $get(p[1]+'_Display');
        try{o_d.innerHTML = p[2];}catch(ex){}
      }
      o.style.backgroundImage  = 'none';
      if(p[0]=='1'){
        o.value='';
        o.focus();
      }
    },
    temp: function() {
    }
    }
</script>