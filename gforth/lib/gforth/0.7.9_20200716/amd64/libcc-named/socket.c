#include <libcc.h>
#include <netdb.h>
#include <unistd.h>
gforth_stackpointers libgfsocket_LTX_gforth_c_gethostname_an_n(GFORTH_ARGS)
{
  ARGN(1,-1);
  x.spx[1]=gethostname((void *)(x.spx[1]),x.spx[0]);
  x.spx += 1;
  return x;
}
#include <sys/types.h>
#include <sys/socket.h>
gforth_stackpointers libgfsocket_LTX_gforth_c_socket_nnn_n(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=socket(x.spx[2],x.spx[1],x.spx[0]);
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfsocket_LTX_gforth_c_connect_nan_n(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=connect(x.spx[2],(void *)(x.spx[1]),x.spx[0]);
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfsocket_LTX_gforth_c_send_nann_n(GFORTH_ARGS)
{
  ARGN(3,-1);
  x.spx[3]=send(x.spx[3],(void *)(x.spx[2]),x.spx[1],x.spx[0]);
  x.spx += 3;
  return x;
}
gforth_stackpointers libgfsocket_LTX_gforth_c_recv_nann_n(GFORTH_ARGS)
{
  ARGN(3,-1);
  x.spx[3]=recv(x.spx[3],(void *)(x.spx[2]),x.spx[1],x.spx[0]);
  x.spx += 3;
  return x;
}
gforth_stackpointers libgfsocket_LTX_gforth_c_recvfrom_nannaa_n(GFORTH_ARGS)
{
  ARGN(5,-1);
  x.spx[5]=recvfrom(x.spx[5],(void *)(x.spx[4]),x.spx[3],x.spx[2],(void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 5;
  return x;
}
gforth_stackpointers libgfsocket_LTX_gforth_c_sendto_nannan_n(GFORTH_ARGS)
{
  ARGN(5,-1);
  x.spx[5]=sendto(x.spx[5],(void *)(x.spx[4]),x.spx[3],x.spx[2],(void *)(x.spx[1]),x.spx[0]);
  x.spx += 5;
  return x;
}
gforth_stackpointers libgfsocket_LTX_gforth_c_listen_nn_n(GFORTH_ARGS)
{
  ARGN(1,-1);
  x.spx[1]=listen(x.spx[1],x.spx[0]);
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfsocket_LTX_gforth_c_bind_nan_n(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=bind(x.spx[2],(void *)(x.spx[1]),x.spx[0]);
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfsocket_LTX_gforth_c_accept_naa_n(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=accept(x.spx[2],(void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 2;
  return x;
}
#include <arpa/inet.h>
gforth_stackpointers libgfsocket_LTX_gforth_c_htonl_n_n(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=htonl(x.spx[0]);
  return x;
}
gforth_stackpointers libgfsocket_LTX_gforth_c_htons_n_n(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=htons(x.spx[0]);
  return x;
}
gforth_stackpointers libgfsocket_LTX_gforth_c_ntohl_n_n(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=ntohl(x.spx[0]);
  return x;
}
#include <netdb.h>
gforth_stackpointers libgfsocket_LTX_gforth_c_getaddrinfo_aaaa_n(GFORTH_ARGS)
{
  ARGN(3,-1);
  x.spx[3]=getaddrinfo((void *)(x.spx[3]),(void *)(x.spx[2]),(void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 3;
  return x;
}
gforth_stackpointers libgfsocket_LTX_gforth_c_freeaddrinfo_a_v(GFORTH_ARGS)
{
  ARGN(0,-1);
  freeaddrinfo((void *)(x.spx[0]));
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfsocket_LTX_gforth_c_gai_strerror_n_a(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=(Cell)gai_strerror(x.spx[0]);
  return x;
}
gforth_stackpointers libgfsocket_LTX_gforth_c_setsockopt_nnnan_n(GFORTH_ARGS)
{
  ARGN(4,-1);
  x.spx[4]=setsockopt(x.spx[4],x.spx[3],x.spx[2],(void *)(x.spx[1]),x.spx[0]);
  x.spx += 4;
  return x;
}
gforth_stackpointers libgfsocket_LTX_gforth_c_getsockname_naa_n(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=getsockname(x.spx[2],(void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 2;
  return x;
}
#include <ifaddrs.h>
gforth_stackpointers libgfsocket_LTX_gforth_c_getifaddrs_a_n(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=getifaddrs((void *)(x.spx[0]));
  return x;
}
gforth_stackpointers libgfsocket_LTX_gforth_c_freeifaddrs_a_v(GFORTH_ARGS)
{
  ARGN(0,-1);
  freeifaddrs((void *)(x.spx[0]));
  x.spx += 1;
  return x;
}
hash_128 gflibcc_hash_socket = "\xA0\x20\x72\x88\xA1\xA7\x92\x7E\xAA\x78\x62\xDF\x86\x91\x5A\x02";
