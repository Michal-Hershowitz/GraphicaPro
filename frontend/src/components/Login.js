import React from "react";
import Button from "@mui/material/Button";
import Dialog from "@mui/material/Dialog";
import DialogActions from "@mui/material/DialogActions";
import DialogContent from "@mui/material/DialogContent";
import DialogContentText from "@mui/material/DialogContentText";
import DialogTitle from "@mui/material/DialogTitle";

import Box from '@mui/material/Box';
import Input from '@mui/material/Input';
import InputLabel from '@mui/material/InputLabel';
import InputAdornment from '@mui/material/InputAdornment';
import FormControl from '@mui/material/FormControl';
import TextField from '@mui/material/TextField';
import AccountCircle from '@mui/icons-material/AccountCircle';
import LockIcon from '@mui/icons-material/Lock';

import IconButton from '@mui/material/IconButton';
import FilledInput from '@mui/material/FilledInput';
import OutlinedInput from '@mui/material/OutlinedInput';
import FormHelperText from '@mui/material/FormHelperText';
import Visibility from '@mui/icons-material/Visibility';
import VisibilityOff from '@mui/icons-material/VisibilityOff';




function Login(){
    const [open, setOpen] = React.useState(false);
    const handleClickOpen = () => {
      setOpen(true);
    };
    const handleClose = () => {
      setOpen(false);
    };


    const [showPassword, setShowPassword] = React.useState(false);

    const handleClickShowPassword = () => setShowPassword((show) => !show);
  
    const handleMouseDownPassword = (event) => {
      event.preventDefault();
    };

    return(
        <>
        

        <Button variant="outlined" onClick={handleClickOpen}>
        התחבר
      </Button>
      <Dialog open={open} onClose={handleClose}>
        {/* <DialogTitle dir="ltr">הוספת לקוח חדש</DialogTitle> */}
        <DialogContent>
          {/* <DialogContentText>
                  To subscribe to this website, please enter your email address
                  here. We will send updates occasionally.
                </DialogContentText> */}
      <br></br>
      <br></br>
        <FormControl variant="standard">
        <InputLabel htmlFor="input-with-icon-adornment">
          
        </InputLabel>
        <Input
          id="input-with-icon-adornment"
          placeholder="שם"
          startAdornment={
            <InputAdornment position="start">
              <AccountCircle />
            </InputAdornment>
          }
        />
      </FormControl>
      
      <br></br>
      <br></br>

      <FormControl variant="standard">
        <InputLabel htmlFor="input-with-icon-adornment">
          
        </InputLabel>
        <Input
          id="input-with-icon-adornment"
          placeholder="סיסמא"
          type={showPassword ? 'text' : 'password'}
          endAdornment={
            <InputAdornment position="end">
              <IconButton
                aria-label="toggle password visibility"
                onClick={handleClickShowPassword}
                onMouseDown={handleMouseDownPassword}
                edge="end"
              >
                {showPassword ? <VisibilityOff /> : <Visibility />}
              </IconButton>
            </InputAdornment>
             }
          startAdornment={
            <InputAdornment position="start">
               <LockIcon/>
            </InputAdornment>
          }
        />
      </FormControl>
      <br></br>
      <br></br>

        </DialogContent>
        <DialogActions>
          <Button onClick={handleClose}>בטל</Button>
          <Button onClick={handleClose}>התחבר</Button>
        </DialogActions>
      </Dialog>
        </>
    );
}
export default Login;