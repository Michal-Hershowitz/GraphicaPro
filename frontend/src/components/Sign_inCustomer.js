import React from "react";
import Button from "@mui/material/Button";
import Dialog from "@mui/material/Dialog";
import DialogActions from "@mui/material/DialogActions";
import DialogContent from "@mui/material/DialogContent";
import DialogContentText from "@mui/material/DialogContentText";
import DialogTitle from "@mui/material/DialogTitle";

import Box from "@mui/material/Box";
import Input from "@mui/material/Input";
import InputLabel from "@mui/material/InputLabel";
import InputAdornment from "@mui/material/InputAdornment";
import FormControl from "@mui/material/FormControl";
import TextField from "@mui/material/TextField";
import AccountCircle from "@mui/icons-material/AccountCircle";
import LockIcon from "@mui/icons-material/Lock";

import IconButton from "@mui/material/IconButton";
import FilledInput from "@mui/material/FilledInput";
import OutlinedInput from "@mui/material/OutlinedInput";
import FormHelperText from "@mui/material/FormHelperText";
import Visibility from "@mui/icons-material/Visibility";
import VisibilityOff from "@mui/icons-material/VisibilityOff";
import CallIcon from "@mui/icons-material/Call";
import HomeRoundedIcon from "@mui/icons-material/HomeRounded";
import AlternateEmailRoundedIcon from "@mui/icons-material/AlternateEmailRounded";
import { useNavigate } from "react-router-dom";
import PinRoundedIcon from "@mui/icons-material/PinRounded";

function Sign_inCustomer() {
  const navigate = useNavigate();

  const [open, setOpen] = React.useState(false);
  const handleClickOpen = () => {
    setOpen(true);
  };
  const handleClose = () => {
    setOpen(false);
  };

  const [showPassword1, setShowPassword1] = React.useState(false);

  const handleClickShowPassword1 = () => setShowPassword1((show) => !show);

  const handleMouseDownPassword1 = (event) => {
    event.preventDefault();
  };
  
  const [showPassword2, setShowPassword2] = React.useState(false);

  const handleClickShowPassword2 = () => setShowPassword2((show) => !show);

  const handleMouseDownPassword2 = (event) => {
    event.preventDefault();
  };

  return (
    <>
      <Button variant="outlined" onClick={handleClickOpen}>
        הירשם
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
            <InputLabel htmlFor="input-with-icon-adornment"></InputLabel>
            <Input
              id="input-with-icon-adornment"
              placeholder=" שם משתמש"
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
            <InputLabel htmlFor="input-with-icon-adornment"></InputLabel>
            <Input
              id="input-with-icon-adornment"
              placeholder="סיסמה"
              type={showPassword1 ? "text" : "password"}
              endAdornment={
                <InputAdornment position="end">
                  <IconButton
                    aria-label="toggle password visibility"
                    onClick={handleClickShowPassword1}
                    onMouseDown={handleMouseDownPassword1}
                    edge="end"
                  >
                    {showPassword1 ? <VisibilityOff /> : <Visibility />}
                  </IconButton>
                </InputAdornment>
              }
              startAdornment={
                <InputAdornment position="start">
                  <LockIcon />
                </InputAdornment>
              }
            />
          </FormControl>
          <br></br>
          <br></br>

          <FormControl variant="standard">
            <InputLabel htmlFor="input-with-icon-adornment"></InputLabel>
            <Input
              id="input-with-icon-adornment"
              placeholder=" אמת סיסמה"
              type={showPassword2 ? "text" : "password"}
              endAdornment={
                <InputAdornment position="end">
                  <IconButton
                    aria-label="toggle password visibility"
                    onClick={handleClickShowPassword2}
                    onMouseDown={handleMouseDownPassword2}
                    edge="end"
                  >
                    {showPassword2 ? <VisibilityOff /> : <Visibility />}
                  </IconButton>
                </InputAdornment>
              }
              startAdornment={
                <InputAdornment position="start">
                  <LockIcon />
                </InputAdornment>
              }
            />
          </FormControl>

          <br></br>
          <br></br>
          <FormControl variant="standard">
            <InputLabel htmlFor="input-with-icon-adornment"></InputLabel>
            <Input
              id="input-with-icon-adornment"
              placeholder=" מייל"
              startAdornment={
                <InputAdornment position="start">
                  <AlternateEmailRoundedIcon />
                </InputAdornment>
              }
            />
          </FormControl>

          <br></br>
          <br></br>
          <FormControl variant="standard">
            <InputLabel htmlFor="input-with-icon-adornment"></InputLabel>
            <Input
              id="input-with-icon-adornment"
              placeholder=" קוד"
              startAdornment={
                <InputAdornment position="start">
                  <PinRoundedIcon />
                </InputAdornment>
              }
            />
          </FormControl>

          <br></br>
          <br></br>
        </DialogContent>
        <DialogActions>
          <Button onClick={handleClose}>בטל</Button>
          <Button onClick={() => navigate(`/Customer/`)}>הירשם</Button>
        </DialogActions>
      </Dialog>
    </>
  );
}
export default Sign_inCustomer;
